using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace ProjetPPE
{
	public partial class Form1 : Form
	{
		public static String connectionString = ConfigurationManager.ConnectionStrings["dbTestJava"].ConnectionString;
		public static MySqlConnection connexion = new MySqlConnection(connectionString);

		public Form1()
		{
			InitializeComponent();

			textBoxFiltre.Focus();
			try
			{
				using (connexion)
				{
					// contructeur commande
					MySqlCommand commandList = new MySqlCommand("select id_commande from commande", connexion);
					connexion.Open();
					MySqlDataReader readerList = commandList.ExecuteReader();
					while (readerList.Read())
					{
						listBoxCommande.Items.Add(readerList["id_commande"]);
					}
					connexion.Close();

					//contructeur produit
					MySqlCommand commandBoxProduit = new MySqlCommand("select id_produit, nom_produit from produit", connexion);
					connexion.Open();
					MySqlDataReader readerBoxProduit = commandBoxProduit.ExecuteReader();
					while (readerBoxProduit.Read())
					{
						comboBoxListeProduit.Items.Add(readerBoxProduit["id_produit"]+" "+readerBoxProduit["nom_produit"]);
					}
					connexion.Close();
				}
					
				//contructeur client

				MySqlCommand command = connexion.CreateCommand();
				MySqlDataReader Reader;
				command.CommandText = "select * from client";
				connexion.Open();
				Reader = command.ExecuteReader();
				while (Reader.Read())
				{
					comboBoxListeClient.Items.Add("N°" + Reader["id_client"] + " " + Reader["nom_client"] + " " + Reader["prenom_client"]);
				}
				connexion.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		//methode reset de l'onglet commande
        public void reset()
        {
            listBoxCommande.Items.Clear();
            try
            {
                using (connexion)
                {
                    connexion.Open();
                    MySqlCommand commandReset = new MySqlCommand("select id_commande from commande", connexion);
                    MySqlDataReader readerReset = commandReset.ExecuteReader();

                    while (readerReset.Read())
                    {
                        listBoxCommande.Items.Add(readerReset["id_commande"]);
                    }
                    connexion.Close();
                }
                textBoxFiltre.Text = null;
                label1Commande.Text = null;
                textBoxNClient.Text = null;
                textBoxDescriptionC.Text = null;
                textBoxNom.Text = null;
                textBoxPrenom.Text = null;
                textBoxAdresse.Text = null;
                textBoxCp.Text = null;
                textBoxVille.Text = null;
                radioButtonModePCB.Checked = false;
                radioButtonModePCheque.Checked = false;
                radioButtonStatutCEnCours.Checked = false;
                radioButtonStatutCExpediee.Checked = false;
                textBoxNFacture.Text = null;
                textBoxDateC.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

		//methode reset de l'onglet produit
		public void resetProduit()
		{
			//vide les champs
			labelNumProduitAffiche.Text = null;
			textBoxNomProduit.Text = null;
			textBoxDescriptionP.Text = null;
			textBoxQteProduit.Text = null;
			textBoxPrixProduit.Text = null;
			comboBoxListeProduit.Items.Clear();
			comboBoxListeProduit.Text = null;

			//reinitialise la liste des produits
			using (connexion)
			{
				MySqlCommand commandBoxProduit = new MySqlCommand("SELECT id_produit FROM produit;", connexion);
				connexion.Open();
				MySqlDataReader readerBoxProduit = commandBoxProduit.ExecuteReader();
				while (readerBoxProduit.Read())
				{
					comboBoxListeProduit.Items.Add(readerBoxProduit["id_produit"]);
				}
				connexion.Close();
			}
		}

		//methode reset de l'onglet client
		public void Effacecombo()
		{
			labelNumClientAffiche.Text = null;
			textBoxNomClient.Text = null;
			textBoxPrenomClient.Text = null;
			textBoxTelClient.Text = null;
			textBoxPseudoClient.Text = null;
			textBoxEmailClient.Text = null;
			labelNbCommandeAffiche.Text = null;
			comboBoxListeClient.Items.Clear();
			comboBoxListeClient.Text = null;

			//requete qui permet d'afficher tout les clients dans la combobox
			MySqlCommand command = connexion.CreateCommand();
			MySqlDataReader Reader;
			command.CommandText = "select * from client";
			connexion.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				comboBoxListeClient.Items.Add("N°" + Reader["id_client"] + " " + Reader["nom_client"] + " " + Reader["prenom_client"]);
			}
			connexion.Close();
		}



		//code de l'onglet commande
		//-----------------------------------------------------------------------------
		private void buttonRechercher_Click(object sender, EventArgs e)
		{
			listBoxCommande.Items.Clear();
			try
			{
				using (connexion)
				{
					connexion.Open();
					MySqlCommand commandRecherche = new MySqlCommand("SELECT id_commande FROM commande WHERE id_commande LIKE '%" + textBoxFiltre.Text + "%';", connexion);
					MySqlDataReader readerRecherche = commandRecherche.ExecuteReader();

					while (readerRecherche.Read())
					{
						listBoxCommande.Items.Add(readerRecherche["id_commande"]);
					}
					connexion.Close();
				}
				if (listBoxCommande.Items.Count == 0)
				{
					listBoxCommande.Items.Add("aucun résultat");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
            this.reset();
		}

		private void listBoxCommande_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int modeP = 0;
				int statutC = 0;

				using (connexion)
				{
					MySqlCommand commandContenu = new MySqlCommand("SELECT id_commande, id_client, description_commande, nom_livraison, prenom_livraison, adresse_livraison, ville_livraison, cp_livraison, id_mode_paiement, id_facture, id_statut_commande, DATE_FORMAT(date_statut_commande, '%Y-%m-%d') AS dateUniquement FROM commande NATURAL JOIN posseder WHERE id_commande = '" + listBoxCommande.Text + "';", connexion);
					connexion.Open();
					MySqlDataReader readerContenu = commandContenu.ExecuteReader();
					while (readerContenu.Read())
					{
						label1Commande.Text = readerContenu["id_commande"].ToString();
						textBoxNClient.Text = readerContenu["id_client"].ToString();
						textBoxDescriptionC.Text = readerContenu["description_commande"].ToString();
						textBoxNom.Text = readerContenu["nom_livraison"].ToString();
						textBoxPrenom.Text = readerContenu["prenom_livraison"].ToString();
                        textBoxAdresse.Text = readerContenu["adresse_livraison"].ToString();
                        textBoxCp.Text = readerContenu["cp_livraison"].ToString();
                        textBoxVille.Text = readerContenu["ville_livraison"].ToString();
						modeP = int.Parse(readerContenu["id_mode_paiement"].ToString());
						statutC = int.Parse(readerContenu["id_statut_commande"].ToString());
                        textBoxNFacture.Text = readerContenu["id_facture"].ToString();
						textBoxDateC.Text = readerContenu["dateUniquement"].ToString();

					}
					connexion.Close();
				}

				if (modeP == 1)
				{
					radioButtonModePCB.Checked = true;
				}
				else if (modeP == 2)
				{
					radioButtonModePCheque.Checked = true;
				}
				

				switch (statutC)
				{
					case 1:
						radioButtonStatutCEnCours.Checked = true;
						break;
					case 2:
						radioButtonStatutCExpediee.Checked = true;
						break;
					default:
						
						break;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonAjouter_Click(object sender, EventArgs e)
		{
            int mode_paiement = 0;
            int statut_C = 0;
            String lastId = "";
			String descriptionCorrigee = textBoxDescriptionC.Text.Replace("'", "\\'");
			String adresseCorrigee = textBoxAdresse.Text.Replace("'", "\\'");

            if (radioButtonModePCB.Checked == true)
            {
                mode_paiement = 1;
            }
            else
            {
                mode_paiement = 2;
            }

            if (radioButtonStatutCEnCours.Checked == true)
            {
                statut_C = 1;
            }
            else
            {
                statut_C = 2;
            }

            try
            {
                
				using (connexion)
                {
					String requeteCommande = "INSERT INTO commande (id_commande, description_commande, adresse_livraison, ville_livraison, cp_livraison, nom_livraison, prenom_livraison, id_client, id_mode_paiement, id_facture) VALUES ('', '" + descriptionCorrigee + "', '" + adresseCorrigee + "', '" + textBoxVille.Text + "', '" + textBoxCp.Text + "', '" + textBoxNom.Text + "', '" + textBoxPrenom.Text + "', '" + textBoxNClient.Text + "', '" + mode_paiement + "', '" + textBoxNFacture.Text + "');" + "SELECT LAST_INSERT_ID();";
                    MySqlCommand commandAjouterCommande = new MySqlCommand(requeteCommande, connexion);
                    
                    connexion.Open();
                    MySqlDataReader readerCommande = commandAjouterCommande.ExecuteReader();
                    while (readerCommande.Read())
                    {
						//récupere l'id de la commande insérée précedement au format texte
                        lastId = readerCommande["LAST_INSERT_ID()"].ToString();
                    }
                    connexion.Close();
                    
                    int lastIdInt = int.Parse(lastId); //convertis l'id obtenue en int
                    String requetePosseder = "INSERT INTO posseder (id_statut_commande, id_commande, date_statut_commande) VALUES ('" + statut_C + "', '" + lastIdInt + "', '" + textBoxDateC.Text + "')";
                    MySqlCommand commandAjouterPosseder = new MySqlCommand(requetePosseder, connexion);
                    connexion.Open();
                    commandAjouterPosseder.ExecuteNonQuery(); // execution de la commande de la table posseder
                    connexion.Close();

                    MessageBox.Show("La commande a été ajoutée");
                    this.reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}

		private void buttonModifier_Click(object sender, EventArgs e)
		{
            int mode_paiement = 0;
            int statut_C = 0;

			String descriptionCorrigee = textBoxDescriptionC.Text.Replace("'", "\\'");
			String adresseCorrigee = textBoxAdresse.Text.Replace("'", "\\'");

            if (radioButtonModePCB.Checked == true)
            {
                mode_paiement = 1;
            }
            else
            {
                mode_paiement = 2;
            }

            if (radioButtonStatutCEnCours.Checked == true)
            {
                statut_C = 1;
            }
            else
            {
                statut_C = 2;
            }

            try
            {
				if (listBoxCommande.Text == "")
				{
					MessageBox.Show("Vous devez sélectionner une commande pour pouvoir la modifier");
				}
				else
				{
					using (connexion)
					{
						String requeteModifCommande = "UPDATE commande SET description_commande='" + descriptionCorrigee + "', adresse_livraison='" + adresseCorrigee + "', ville_livraison='" + textBoxVille.Text + "', cp_livraison='" + textBoxCp.Text + "', nom_livraison='" + textBoxNom.Text + "', prenom_livraison='" + textBoxPrenom.Text + "', id_client='" + textBoxNClient.Text + "', id_mode_paiement='" + mode_paiement + "', id_facture='" + textBoxNFacture.Text + "' WHERE id_commande = '" + label1Commande.Text + "';";
						String requeteModifPosseder = "UPDATE posseder SET id_statut_commande='" + statut_C + "', date_statut_commande='" + textBoxDateC.Text + "' WHERE id_commande = '" + label1Commande.Text + "';";
						Console.WriteLine(requeteModifCommande);
						MySqlCommand commandModifCommande = new MySqlCommand(requeteModifCommande, connexion);
						MySqlCommand commandModifPosseder = new MySqlCommand(requeteModifPosseder, connexion);
						connexion.Open();
						commandModifCommande.ExecuteNonQuery();
						commandModifPosseder.ExecuteNonQuery();
						connexion.Close();
						MessageBox.Show("La commande a été mise à jour");
						this.reset();
					}
				}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}

		private void buttonSupprimer_Click(object sender, EventArgs e)
		{
            try
            {
				if (listBoxCommande.Text == "")
				{
					MessageBox.Show("Vous devez sélectionner une commande pour pouvoir la supprimer");
				}
				else
				{
					using (connexion)
					{
						String requeteModifCommande = "DELETE FROM commande WHERE id_commande = '" + label1Commande.Text + "'";
						String requeteModifPosseder = "DELETE FROM posseder WHERE id_commande = '" + label1Commande.Text + "'";
						MySqlCommand commandeRequeteModifCommande = new MySqlCommand(requeteModifCommande, connexion);
						MySqlCommand commandeRequeteModifPosseder = new MySqlCommand(requeteModifPosseder, connexion);
						connexion.Open();
						commandeRequeteModifCommande.ExecuteNonQuery();
						commandeRequeteModifPosseder.ExecuteNonQuery();
						connexion.Close();
						MessageBox.Show("La commande a été supprimé");
						this.reset();
					}
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}
		
		//--------------------------------------------------------------------------




		//code de l'onglet client
		//--------------------------------------------------------------------------
		private void comboBoxListeClient_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void buttonAfficher_Click(object sender, EventArgs e)
		{
			//Affiche un message d'alerte si l'utilisateur clique sur afficher sans avoir choisi un client
			if (comboBoxListeClient.Text == "")
			{
				MessageBox.Show("Veuillez choisir un client dans la liste déroulante");
			}
			else
			{
				//Stock la valeur du comboBox dans la variable input 
				String input = comboBoxListeClient.Text;
				String resultString = "";

				//Recupere uniquement les nombres de la variable input qui correspond a l'id du client choisi.
				MatchCollection matches = Regex.Matches(input, "[0-9]");
				foreach (Match match in matches)
				{
					resultString += match.Value;
				}
				//Converti la variable resultString en int
				int result = int.Parse(resultString);


				//requete pour afficher les information du client dans le formulaire
				MySqlCommand command = connexion.CreateCommand();
				MySqlDataReader Reader;
				command.CommandText = "select * from client WHERE id_client = " + result;
				connexion.Open();
				Reader = command.ExecuteReader();
				if (Reader.Read())
				{
					labelNumClientAffiche.Text = Reader["id_client"].ToString();
					textBoxNomClient.Text = Reader["nom_client"].ToString();
					textBoxPrenomClient.Text = Reader["prenom_client"].ToString();
					textBoxTelClient.Text = Reader["tel_client"].ToString();
					textBoxPseudoClient.Text = Reader["pseudo_client"].ToString();
					textBoxEmailClient.Text = Reader["email_client"].ToString();
				}
				connexion.Close();

				//connexion a la bdd pour calculer le nombre de commande du client
				MySqlCommand command2 = connexion.CreateCommand();
				MySqlDataReader Reader2;
				command2.CommandText = "select count(*) as nbr from client NATURAL JOIN commande WHERE id_client = " + result;
				connexion.Open();
				Reader2 = command2.ExecuteReader();
				if (Reader2.Read())
				{
					labelNbCommandeAffiche.Text = Reader2["nbr"].ToString();
				}
				connexion.Close();
			}
		}

		private void buttonReinitialiser_Click(object sender, EventArgs e)
		{
			this.Effacecombo();
		}

		private void buttonAjouterClient_Click(object sender, EventArgs e)
		{
			//Affiche un message d'alerte si l'utilisateur clique sur ajouter sans faire une réinitialisation
			if (labelNumClientAffiche.Text != "")
			{
				MessageBox.Show("Veuillez cliquer sur le bouton 'Reinitialiser' avant d'ajouter un nouveau client");
			}
			else
			{
				//Affiche un message d'alerte si l'utilisateur n'a pas saisi tout les champs
				if (textBoxNomClient.Text == "" || textBoxPrenomClient.Text == "" || textBoxTelClient.Text == "" || textBoxPseudoClient.Text == "" || textBoxEmailClient.Text == "")
				{
					MessageBox.Show("Veuillez saisir tout les champs avant d'ajouter un nouveaux client.");
				}
				else
				{

					//connexion a la bdd pour ajouter un client dans la bdd
					MySqlCommand command = connexion.CreateCommand();
					// le mot de passe par default est 0000
					command.CommandText = "INSERT INTO client (`id_client`, `nom_client`, `prenom_client`, `tel_client`, `email_client`, `pseudo_client`, `mdp_client`) VALUES ('','" + textBoxNomClient.Text + "', '" + textBoxPrenomClient.Text + "', '" + textBoxTelClient.Text + "', '" + textBoxEmailClient.Text + "', '" + textBoxPseudoClient.Text + "', '0000')";
					connexion.Open();
					command.ExecuteNonQuery();
					connexion.Close();
					MessageBox.Show("Client ajouté avec succès");
					this.Effacecombo();
				}
			}
		}
		
		private void buttonModifierClient_Click(object sender, EventArgs e)
		{
			//Affiche un message d'alerte si l'utilisateur clique sur modifier sans avoir choisi un client
			if (labelNumClientAffiche.Text == "")
			{
				MessageBox.Show("Veuillez choisir un client dans la liste déroulante avant de le modifier");
			}
			else
			{
				//Requete sql pour modifier un client
				MySqlCommand command = connexion.CreateCommand();
				command.CommandText = "UPDATE client SET `nom_client` = '" + textBoxNomClient.Text + "', `prenom_client` = '" + textBoxPrenomClient.Text + "', `tel_client` = '" + textBoxTelClient.Text + "', `email_client` = '" + textBoxEmailClient.Text + "', `pseudo_client` = '" + textBoxPseudoClient.Text + "' WHERE `client`.`id_client` = " + labelNumClientAffiche.Text;
				connexion.Open();
				command.ExecuteNonQuery();
				connexion.Close();
				MessageBox.Show("Client modifié avec succès");
				this.Effacecombo();
			}
		}

		private void buttonSupprimerClient_Click(object sender, EventArgs e)
		{
			//Affiche un message d'alerte si l'utilisateur clique sur supprimer sans avoir choisi un client
			if (labelNumClientAffiche.Text == "")
			{
				MessageBox.Show("Veuillez choisir un client dans la liste déroulante avant de le supprimer.");
			}
			else
			{
				//requete pour supprimer un client dans la bdd
				MySqlCommand command = connexion.CreateCommand();

				// DELETE FROM `gsbadmin`.`client` WHERE `client`.`id_client` = 5
				command.CommandText = "DELETE FROM client WHERE  id_client = " + labelNumClientAffiche.Text;
				connexion.Open();
				command.ExecuteNonQuery();
				connexion.Close();
				MessageBox.Show("Client supprimé avec succès.");
				this.Effacecombo();
			}
		}

		//---------------------------------------------------------------------------




		//code de l'onglet produit
		//----------------------------------------------------------------------------

		private void comboBoxListeProduit_SelectedIndexChanged(object sender, EventArgs e)
		{
			//requete pour afficher les informations du produit dans le formulaire
			using(connexion)
			{
				String requete = "select * from produit where id_produit = '" + comboBoxListeProduit.Text + "';";
				MySqlCommand command = new MySqlCommand(requete, connexion);
				connexion.Open();
				MySqlDataReader Reader = command.ExecuteReader();
				if (Reader.Read())
				{
					labelNumProduitAffiche.Text = Reader["id_produit"].ToString();
					textBoxNomProduit.Text = Reader["nom_produit"].ToString();
					textBoxDescriptionP.Text = Reader["description_produit"].ToString();
					textBoxQteProduit.Text = Reader["quantite_produit"].ToString();
					textBoxPrixProduit.Text = Reader["prix_produit"].ToString();
				}
				connexion.Close();
			}
			
		}

		private void buttonReinitialiserProduit_Click(object sender, EventArgs e)
		{
			this.resetProduit();
		}

		private void buttonAjouterProduit_Click(object sender, EventArgs e)
		{
			//ajoute les antislash au quote pour compatibilité avec la base (champs description)
			String descriptionCorrigee = textBoxDescriptionP.Text.Replace("'", "\\'");
			
			using (connexion)
			{
				//Affiche un message d'alerte si l'utilisateur clique sur ajouter sans faire une réinitialisation
				if (labelNumClientAffiche.Text != "")
				{
					MessageBox.Show("Veuillez cliquer sur le bouton 'Reinitialiser' avant d'ajouter un nouveau produit");
				}
				else
				{
					//Affiche un message d'alerte si l'utilisateur n'a pas saisi tout les champs
					if (textBoxNomProduit.Text == "" || textBoxDescriptionP.Text == "" || textBoxQteProduit.Text == "" || textBoxPrixProduit.Text == "")
					{
						MessageBox.Show("Veuillez saisir tout les champs avant d'ajouter un nouveaux produit.");
					}
					else
					{

						//requete d'insertion du produit dans la base
						String requeteAjouterProduit = "INSERT INTO produit (`id_produit`, `nom_produit`, `description_produit`, `quantite_produit`, `prix_produit`) VALUES ('','" + textBoxNomProduit.Text + "', '" + descriptionCorrigee + "', '" + textBoxQteProduit.Text + "', '" + textBoxPrixProduit.Text + "')";
						MySqlCommand command = new MySqlCommand(requeteAjouterProduit, connexion);
						connexion.Open();
						command.ExecuteNonQuery();
						connexion.Close();
						MessageBox.Show("Le produit a été ajouté");
						this.resetProduit();
					}
				}
			}
		}

		private void buttonModifierProduit_Click(object sender, EventArgs e)
		{
			String descriptionCorrigee = textBoxDescriptionP.Text.Replace("'", "\\'");

			using (connexion)
			{
				//Affiche un message d'alerte si l'utilisateur n'a pas saisi tout les champs
				if (textBoxNomProduit.Text == "" || textBoxDescriptionP.Text == "" || textBoxQteProduit.Text == "" || textBoxPrixProduit.Text == "")
				{
					MessageBox.Show("Veuillez saisir tout les champs avant d'ajouter un nouveaux produit.");
				}
				else
				{
					//requete de mise à jour du produit dans la base
					String requeteModifierProduit = "UPDATE produit SET `nom_produit` = '"+textBoxNomProduit.Text+"', `description_produit` = '"+descriptionCorrigee+"', `quantite_produit` = '"+textBoxQteProduit.Text+"', `prix_produit` = '"+textBoxPrixProduit.Text+"' WHERE id_produit = '"+labelNumProduitAffiche.Text+"';";
					MySqlCommand command = new MySqlCommand(requeteModifierProduit, connexion);
					connexion.Open();
					command.ExecuteNonQuery();
					connexion.Close();
					MessageBox.Show("Le produit a été modifié");
					this.resetProduit();
				}
				
			}
		}

		private void buttonSupprimerProduit_Click(object sender, EventArgs e)
		{
			if(labelNumProduitAffiche.Text == "")
			{
				MessageBox.Show("Vous devez selectionner un produit");
			}
			else
			{
				using (connexion)
				{
					//requete de suppression du produit dans la base
					String requeteSupprimerProduit = "DELETE from produit WHERE id_produit = '"+labelNumProduitAffiche.Text+"';";
					MySqlCommand command = new MySqlCommand(requeteSupprimerProduit, connexion);
					connexion.Open();
					command.ExecuteNonQuery();
					connexion.Close();
					MessageBox.Show("Le produit a été supprimé");
					this.resetProduit();				
				}
			}
			
		}

		



	}
}
