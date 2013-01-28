namespace ProjetPPE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageCommande = new System.Windows.Forms.TabPage();
			this.buttonReset = new System.Windows.Forms.Button();
			this.groupBoxContenu = new System.Windows.Forms.GroupBox();
			this.labelInfoDate = new System.Windows.Forms.Label();
			this.textBoxVille = new System.Windows.Forms.TextBox();
			this.textBoxCp = new System.Windows.Forms.TextBox();
			this.labelVille = new System.Windows.Forms.Label();
			this.labelCp = new System.Windows.Forms.Label();
			this.label1Commande = new System.Windows.Forms.Label();
			this.textBoxDateC = new System.Windows.Forms.TextBox();
			this.labelDateC = new System.Windows.Forms.Label();
			this.textBoxNFacture = new System.Windows.Forms.TextBox();
			this.labelNFacture = new System.Windows.Forms.Label();
			this.panelStatutC = new System.Windows.Forms.Panel();
			this.radioButtonStatutCEnCours = new System.Windows.Forms.RadioButton();
			this.radioButtonStatutCExpediee = new System.Windows.Forms.RadioButton();
			this.panelModeP = new System.Windows.Forms.Panel();
			this.radioButtonModePCB = new System.Windows.Forms.RadioButton();
			this.radioButtonModePCheque = new System.Windows.Forms.RadioButton();
			this.textBoxDescriptionC = new System.Windows.Forms.TextBox();
			this.labelDescriptionC = new System.Windows.Forms.Label();
			this.labelNCommande = new System.Windows.Forms.Label();
			this.labelNClient = new System.Windows.Forms.Label();
			this.labelNom = new System.Windows.Forms.Label();
			this.labelPrenom = new System.Windows.Forms.Label();
			this.labelAdresse = new System.Windows.Forms.Label();
			this.textBoxAdresse = new System.Windows.Forms.TextBox();
			this.labelModeP = new System.Windows.Forms.Label();
			this.textBoxPrenom = new System.Windows.Forms.TextBox();
			this.labelStatutC = new System.Windows.Forms.Label();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.textBoxNClient = new System.Windows.Forms.TextBox();
			this.buttonSupprimer = new System.Windows.Forms.Button();
			this.buttonModifier = new System.Windows.Forms.Button();
			this.buttonAjouter = new System.Windows.Forms.Button();
			this.listBoxCommande = new System.Windows.Forms.ListBox();
			this.buttonRechercher = new System.Windows.Forms.Button();
			this.labelTitreCommande = new System.Windows.Forms.Label();
			this.textBoxFiltre = new System.Windows.Forms.TextBox();
			this.tabPageProduit = new System.Windows.Forms.TabPage();
			this.labelEuro = new System.Windows.Forms.Label();
			this.labelNumProduitAffiche = new System.Windows.Forms.Label();
			this.buttonSupprimerProduit = new System.Windows.Forms.Button();
			this.buttonModifierProduit = new System.Windows.Forms.Button();
			this.buttonAjouterProduit = new System.Windows.Forms.Button();
			this.textBoxPrixProduit = new System.Windows.Forms.TextBox();
			this.textBoxQteProduit = new System.Windows.Forms.TextBox();
			this.textBoxDescriptionP = new System.Windows.Forms.TextBox();
			this.textBoxNomProduit = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelNumProduit = new System.Windows.Forms.Label();
			this.buttonReinitialiserProduit = new System.Windows.Forms.Button();
			this.comboBoxListeProduit = new System.Windows.Forms.ComboBox();
			this.labelTitreProduit = new System.Windows.Forms.Label();
			this.tabPageClient = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonSupprimerClient = new System.Windows.Forms.Button();
			this.buttonModifierClient = new System.Windows.Forms.Button();
			this.buttonAjouterClient = new System.Windows.Forms.Button();
			this.labelNumClientAffiche = new System.Windows.Forms.Label();
			this.labelNbCommandeAffiche = new System.Windows.Forms.Label();
			this.textBoxEmailClient = new System.Windows.Forms.TextBox();
			this.textBoxPseudoClient = new System.Windows.Forms.TextBox();
			this.textBoxTelClient = new System.Windows.Forms.TextBox();
			this.textBoxPrenomClient = new System.Windows.Forms.TextBox();
			this.textBoxNomClient = new System.Windows.Forms.TextBox();
			this.labelNBCommande = new System.Windows.Forms.Label();
			this.labelEmailClient = new System.Windows.Forms.Label();
			this.labelPseudoClient = new System.Windows.Forms.Label();
			this.labelTelClient = new System.Windows.Forms.Label();
			this.labelPrenomClient = new System.Windows.Forms.Label();
			this.labelNomClient = new System.Windows.Forms.Label();
			this.labelNumClient = new System.Windows.Forms.Label();
			this.buttonReinitialiser = new System.Windows.Forms.Button();
			this.buttonAfficher = new System.Windows.Forms.Button();
			this.comboBoxListeClient = new System.Windows.Forms.ComboBox();
			this.labelTitreClient = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageCommande.SuspendLayout();
			this.groupBoxContenu.SuspendLayout();
			this.panelStatutC.SuspendLayout();
			this.panelModeP.SuspendLayout();
			this.tabPageProduit.SuspendLayout();
			this.tabPageClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageCommande);
			this.tabControl1.Controls.Add(this.tabPageProduit);
			this.tabControl1.Controls.Add(this.tabPageClient);
			this.tabControl1.Location = new System.Drawing.Point(-1, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(797, 567);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageCommande
			// 
			this.tabPageCommande.Controls.Add(this.buttonReset);
			this.tabPageCommande.Controls.Add(this.groupBoxContenu);
			this.tabPageCommande.Controls.Add(this.buttonSupprimer);
			this.tabPageCommande.Controls.Add(this.buttonModifier);
			this.tabPageCommande.Controls.Add(this.buttonAjouter);
			this.tabPageCommande.Controls.Add(this.listBoxCommande);
			this.tabPageCommande.Controls.Add(this.buttonRechercher);
			this.tabPageCommande.Controls.Add(this.labelTitreCommande);
			this.tabPageCommande.Controls.Add(this.textBoxFiltre);
			this.tabPageCommande.Location = new System.Drawing.Point(4, 22);
			this.tabPageCommande.Name = "tabPageCommande";
			this.tabPageCommande.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCommande.Size = new System.Drawing.Size(789, 541);
			this.tabPageCommande.TabIndex = 0;
			this.tabPageCommande.Text = "Commande";
			this.tabPageCommande.UseVisualStyleBackColor = true;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(157, 67);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(47, 20);
			this.buttonReset.TabIndex = 22;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// groupBoxContenu
			// 
			this.groupBoxContenu.Controls.Add(this.labelInfoDate);
			this.groupBoxContenu.Controls.Add(this.textBoxVille);
			this.groupBoxContenu.Controls.Add(this.textBoxCp);
			this.groupBoxContenu.Controls.Add(this.labelVille);
			this.groupBoxContenu.Controls.Add(this.labelCp);
			this.groupBoxContenu.Controls.Add(this.label1Commande);
			this.groupBoxContenu.Controls.Add(this.textBoxDateC);
			this.groupBoxContenu.Controls.Add(this.labelDateC);
			this.groupBoxContenu.Controls.Add(this.textBoxNFacture);
			this.groupBoxContenu.Controls.Add(this.labelNFacture);
			this.groupBoxContenu.Controls.Add(this.panelStatutC);
			this.groupBoxContenu.Controls.Add(this.panelModeP);
			this.groupBoxContenu.Controls.Add(this.textBoxDescriptionC);
			this.groupBoxContenu.Controls.Add(this.labelDescriptionC);
			this.groupBoxContenu.Controls.Add(this.labelNCommande);
			this.groupBoxContenu.Controls.Add(this.labelNClient);
			this.groupBoxContenu.Controls.Add(this.labelNom);
			this.groupBoxContenu.Controls.Add(this.labelPrenom);
			this.groupBoxContenu.Controls.Add(this.labelAdresse);
			this.groupBoxContenu.Controls.Add(this.textBoxAdresse);
			this.groupBoxContenu.Controls.Add(this.labelModeP);
			this.groupBoxContenu.Controls.Add(this.textBoxPrenom);
			this.groupBoxContenu.Controls.Add(this.labelStatutC);
			this.groupBoxContenu.Controls.Add(this.textBoxNom);
			this.groupBoxContenu.Controls.Add(this.textBoxNClient);
			this.groupBoxContenu.Location = new System.Drawing.Point(268, 15);
			this.groupBoxContenu.Name = "groupBoxContenu";
			this.groupBoxContenu.Size = new System.Drawing.Size(483, 469);
			this.groupBoxContenu.TabIndex = 21;
			this.groupBoxContenu.TabStop = false;
			this.groupBoxContenu.Text = "Contenu";
			// 
			// labelInfoDate
			// 
			this.labelInfoDate.AutoSize = true;
			this.labelInfoDate.Location = new System.Drawing.Point(300, 440);
			this.labelInfoDate.Name = "labelInfoDate";
			this.labelInfoDate.Size = new System.Drawing.Size(69, 13);
			this.labelInfoDate.TabIndex = 39;
			this.labelInfoDate.Text = "AAAA-MM-JJ";
			// 
			// textBoxVille
			// 
			this.textBoxVille.Location = new System.Drawing.Point(169, 297);
			this.textBoxVille.Name = "textBoxVille";
			this.textBoxVille.Size = new System.Drawing.Size(291, 20);
			this.textBoxVille.TabIndex = 38;
			// 
			// textBoxCp
			// 
			this.textBoxCp.Location = new System.Drawing.Point(169, 262);
			this.textBoxCp.Name = "textBoxCp";
			this.textBoxCp.Size = new System.Drawing.Size(125, 20);
			this.textBoxCp.TabIndex = 37;
			// 
			// labelVille
			// 
			this.labelVille.AutoSize = true;
			this.labelVille.Location = new System.Drawing.Point(18, 300);
			this.labelVille.Name = "labelVille";
			this.labelVille.Size = new System.Drawing.Size(32, 13);
			this.labelVille.TabIndex = 36;
			this.labelVille.Text = "Ville :";
			// 
			// labelCp
			// 
			this.labelCp.AutoSize = true;
			this.labelCp.Location = new System.Drawing.Point(18, 265);
			this.labelCp.Name = "labelCp";
			this.labelCp.Size = new System.Drawing.Size(69, 13);
			this.labelCp.TabIndex = 35;
			this.labelCp.Text = "Code postal :";
			// 
			// label1Commande
			// 
			this.label1Commande.AutoSize = true;
			this.label1Commande.Location = new System.Drawing.Point(166, 20);
			this.label1Commande.Name = "label1Commande";
			this.label1Commande.Size = new System.Drawing.Size(0, 13);
			this.label1Commande.TabIndex = 34;
			// 
			// textBoxDateC
			// 
			this.textBoxDateC.Location = new System.Drawing.Point(169, 437);
			this.textBoxDateC.Name = "textBoxDateC";
			this.textBoxDateC.Size = new System.Drawing.Size(125, 20);
			this.textBoxDateC.TabIndex = 33;
			// 
			// labelDateC
			// 
			this.labelDateC.AutoSize = true;
			this.labelDateC.Location = new System.Drawing.Point(18, 440);
			this.labelDateC.Name = "labelDateC";
			this.labelDateC.Size = new System.Drawing.Size(91, 13);
			this.labelDateC.TabIndex = 32;
			this.labelDateC.Text = "Date commande :";
			// 
			// textBoxNFacture
			// 
			this.textBoxNFacture.Location = new System.Drawing.Point(169, 402);
			this.textBoxNFacture.Name = "textBoxNFacture";
			this.textBoxNFacture.Size = new System.Drawing.Size(291, 20);
			this.textBoxNFacture.TabIndex = 31;
			// 
			// labelNFacture
			// 
			this.labelNFacture.AutoSize = true;
			this.labelNFacture.Location = new System.Drawing.Point(18, 405);
			this.labelNFacture.Name = "labelNFacture";
			this.labelNFacture.Size = new System.Drawing.Size(61, 13);
			this.labelNFacture.TabIndex = 30;
			this.labelNFacture.Text = "N°Facture :";
			// 
			// panelStatutC
			// 
			this.panelStatutC.Controls.Add(this.radioButtonStatutCEnCours);
			this.panelStatutC.Controls.Add(this.radioButtonStatutCExpediee);
			this.panelStatutC.Location = new System.Drawing.Point(169, 367);
			this.panelStatutC.Name = "panelStatutC";
			this.panelStatutC.Size = new System.Drawing.Size(291, 20);
			this.panelStatutC.TabIndex = 29;
			// 
			// radioButtonStatutCEnCours
			// 
			this.radioButtonStatutCEnCours.AutoSize = true;
			this.radioButtonStatutCEnCours.Location = new System.Drawing.Point(3, 1);
			this.radioButtonStatutCEnCours.Name = "radioButtonStatutCEnCours";
			this.radioButtonStatutCEnCours.Size = new System.Drawing.Size(67, 17);
			this.radioButtonStatutCEnCours.TabIndex = 22;
			this.radioButtonStatutCEnCours.TabStop = true;
			this.radioButtonStatutCEnCours.Text = "En cours";
			this.radioButtonStatutCEnCours.UseVisualStyleBackColor = true;
			// 
			// radioButtonStatutCExpediee
			// 
			this.radioButtonStatutCExpediee.AutoSize = true;
			this.radioButtonStatutCExpediee.Location = new System.Drawing.Point(147, 1);
			this.radioButtonStatutCExpediee.Name = "radioButtonStatutCExpediee";
			this.radioButtonStatutCExpediee.Size = new System.Drawing.Size(69, 17);
			this.radioButtonStatutCExpediee.TabIndex = 23;
			this.radioButtonStatutCExpediee.TabStop = true;
			this.radioButtonStatutCExpediee.Text = "Expédiée";
			this.radioButtonStatutCExpediee.UseVisualStyleBackColor = true;
			// 
			// panelModeP
			// 
			this.panelModeP.Controls.Add(this.radioButtonModePCB);
			this.panelModeP.Controls.Add(this.radioButtonModePCheque);
			this.panelModeP.Location = new System.Drawing.Point(169, 332);
			this.panelModeP.Name = "panelModeP";
			this.panelModeP.Size = new System.Drawing.Size(291, 20);
			this.panelModeP.TabIndex = 28;
			// 
			// radioButtonModePCB
			// 
			this.radioButtonModePCB.AutoSize = true;
			this.radioButtonModePCB.Location = new System.Drawing.Point(3, 1);
			this.radioButtonModePCB.Name = "radioButtonModePCB";
			this.radioButtonModePCB.Size = new System.Drawing.Size(94, 17);
			this.radioButtonModePCB.TabIndex = 26;
			this.radioButtonModePCB.TabStop = true;
			this.radioButtonModePCB.Text = "Carte bancaire";
			this.radioButtonModePCB.UseVisualStyleBackColor = true;
			// 
			// radioButtonModePCheque
			// 
			this.radioButtonModePCheque.AutoSize = true;
			this.radioButtonModePCheque.Location = new System.Drawing.Point(147, 1);
			this.radioButtonModePCheque.Name = "radioButtonModePCheque";
			this.radioButtonModePCheque.Size = new System.Drawing.Size(62, 17);
			this.radioButtonModePCheque.TabIndex = 27;
			this.radioButtonModePCheque.TabStop = true;
			this.radioButtonModePCheque.Text = "Chèque";
			this.radioButtonModePCheque.UseVisualStyleBackColor = true;
			// 
			// textBoxDescriptionC
			// 
			this.textBoxDescriptionC.Location = new System.Drawing.Point(169, 87);
			this.textBoxDescriptionC.Multiline = true;
			this.textBoxDescriptionC.Name = "textBoxDescriptionC";
			this.textBoxDescriptionC.Size = new System.Drawing.Size(291, 55);
			this.textBoxDescriptionC.TabIndex = 19;
			// 
			// labelDescriptionC
			// 
			this.labelDescriptionC.AutoSize = true;
			this.labelDescriptionC.Location = new System.Drawing.Point(18, 90);
			this.labelDescriptionC.Name = "labelDescriptionC";
			this.labelDescriptionC.Size = new System.Drawing.Size(121, 13);
			this.labelDescriptionC.TabIndex = 18;
			this.labelDescriptionC.Text = "Description commande :";
			// 
			// labelNCommande
			// 
			this.labelNCommande.AutoSize = true;
			this.labelNCommande.Location = new System.Drawing.Point(18, 20);
			this.labelNCommande.Name = "labelNCommande";
			this.labelNCommande.Size = new System.Drawing.Size(81, 13);
			this.labelNCommande.TabIndex = 4;
			this.labelNCommande.Text = "N° Commande :";
			// 
			// labelNClient
			// 
			this.labelNClient.AutoSize = true;
			this.labelNClient.Location = new System.Drawing.Point(18, 55);
			this.labelNClient.Name = "labelNClient";
			this.labelNClient.Size = new System.Drawing.Size(54, 13);
			this.labelNClient.TabIndex = 5;
			this.labelNClient.Text = "N° Client :";
			// 
			// labelNom
			// 
			this.labelNom.AutoSize = true;
			this.labelNom.Location = new System.Drawing.Point(18, 160);
			this.labelNom.Name = "labelNom";
			this.labelNom.Size = new System.Drawing.Size(35, 13);
			this.labelNom.TabIndex = 6;
			this.labelNom.Text = "Nom :";
			// 
			// labelPrenom
			// 
			this.labelPrenom.AutoSize = true;
			this.labelPrenom.Location = new System.Drawing.Point(18, 195);
			this.labelPrenom.Name = "labelPrenom";
			this.labelPrenom.Size = new System.Drawing.Size(49, 13);
			this.labelPrenom.TabIndex = 7;
			this.labelPrenom.Text = "Prénom :";
			// 
			// labelAdresse
			// 
			this.labelAdresse.AutoSize = true;
			this.labelAdresse.Location = new System.Drawing.Point(18, 230);
			this.labelAdresse.Name = "labelAdresse";
			this.labelAdresse.Size = new System.Drawing.Size(51, 13);
			this.labelAdresse.TabIndex = 8;
			this.labelAdresse.Text = "Adresse :";
			// 
			// textBoxAdresse
			// 
			this.textBoxAdresse.Location = new System.Drawing.Point(169, 227);
			this.textBoxAdresse.Name = "textBoxAdresse";
			this.textBoxAdresse.Size = new System.Drawing.Size(291, 20);
			this.textBoxAdresse.TabIndex = 15;
			// 
			// labelModeP
			// 
			this.labelModeP.AutoSize = true;
			this.labelModeP.Location = new System.Drawing.Point(18, 335);
			this.labelModeP.Name = "labelModeP";
			this.labelModeP.Size = new System.Drawing.Size(86, 13);
			this.labelModeP.TabIndex = 10;
			this.labelModeP.Text = "Mode paiement :";
			// 
			// textBoxPrenom
			// 
			this.textBoxPrenom.Location = new System.Drawing.Point(169, 192);
			this.textBoxPrenom.Name = "textBoxPrenom";
			this.textBoxPrenom.Size = new System.Drawing.Size(291, 20);
			this.textBoxPrenom.TabIndex = 14;
			// 
			// labelStatutC
			// 
			this.labelStatutC.AutoSize = true;
			this.labelStatutC.Location = new System.Drawing.Point(18, 370);
			this.labelStatutC.Name = "labelStatutC";
			this.labelStatutC.Size = new System.Drawing.Size(96, 13);
			this.labelStatutC.TabIndex = 11;
			this.labelStatutC.Text = "Statut commande :";
			// 
			// textBoxNom
			// 
			this.textBoxNom.Location = new System.Drawing.Point(169, 157);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(291, 20);
			this.textBoxNom.TabIndex = 13;
			// 
			// textBoxNClient
			// 
			this.textBoxNClient.Location = new System.Drawing.Point(169, 52);
			this.textBoxNClient.Name = "textBoxNClient";
			this.textBoxNClient.Size = new System.Drawing.Size(291, 20);
			this.textBoxNClient.TabIndex = 12;
			// 
			// buttonSupprimer
			// 
			this.buttonSupprimer.Location = new System.Drawing.Point(565, 490);
			this.buttonSupprimer.Name = "buttonSupprimer";
			this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
			this.buttonSupprimer.TabIndex = 20;
			this.buttonSupprimer.Text = "Supprimer";
			this.buttonSupprimer.UseVisualStyleBackColor = true;
			this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
			// 
			// buttonModifier
			// 
			this.buttonModifier.Location = new System.Drawing.Point(445, 490);
			this.buttonModifier.Name = "buttonModifier";
			this.buttonModifier.Size = new System.Drawing.Size(75, 23);
			this.buttonModifier.TabIndex = 19;
			this.buttonModifier.Text = "Modifier";
			this.buttonModifier.UseVisualStyleBackColor = true;
			this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
			// 
			// buttonAjouter
			// 
			this.buttonAjouter.Location = new System.Drawing.Point(325, 490);
			this.buttonAjouter.Name = "buttonAjouter";
			this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
			this.buttonAjouter.TabIndex = 18;
			this.buttonAjouter.Text = "Ajouter";
			this.buttonAjouter.UseVisualStyleBackColor = true;
			this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
			// 
			// listBoxCommande
			// 
			this.listBoxCommande.FormattingEnabled = true;
			this.listBoxCommande.Location = new System.Drawing.Point(13, 67);
			this.listBoxCommande.Name = "listBoxCommande";
			this.listBoxCommande.Size = new System.Drawing.Size(138, 329);
			this.listBoxCommande.TabIndex = 3;
			this.listBoxCommande.SelectedIndexChanged += new System.EventHandler(this.listBoxCommande_SelectedIndexChanged);
			// 
			// buttonRechercher
			// 
			this.buttonRechercher.Location = new System.Drawing.Point(157, 42);
			this.buttonRechercher.Name = "buttonRechercher";
			this.buttonRechercher.Size = new System.Drawing.Size(47, 20);
			this.buttonRechercher.TabIndex = 2;
			this.buttonRechercher.Text = "OK";
			this.buttonRechercher.UseVisualStyleBackColor = true;
			this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
			// 
			// labelTitreCommande
			// 
			this.labelTitreCommande.AutoSize = true;
			this.labelTitreCommande.Location = new System.Drawing.Point(10, 15);
			this.labelTitreCommande.Name = "labelTitreCommande";
			this.labelTitreCommande.Size = new System.Drawing.Size(115, 13);
			this.labelTitreCommande.TabIndex = 1;
			this.labelTitreCommande.Text = "Liste des commandes :";
			// 
			// textBoxFiltre
			// 
			this.textBoxFiltre.Location = new System.Drawing.Point(13, 42);
			this.textBoxFiltre.Name = "textBoxFiltre";
			this.textBoxFiltre.Size = new System.Drawing.Size(138, 20);
			this.textBoxFiltre.TabIndex = 0;
			// 
			// tabPageProduit
			// 
			this.tabPageProduit.Controls.Add(this.labelEuro);
			this.tabPageProduit.Controls.Add(this.labelNumProduitAffiche);
			this.tabPageProduit.Controls.Add(this.buttonSupprimerProduit);
			this.tabPageProduit.Controls.Add(this.buttonModifierProduit);
			this.tabPageProduit.Controls.Add(this.buttonAjouterProduit);
			this.tabPageProduit.Controls.Add(this.textBoxPrixProduit);
			this.tabPageProduit.Controls.Add(this.textBoxQteProduit);
			this.tabPageProduit.Controls.Add(this.textBoxDescriptionP);
			this.tabPageProduit.Controls.Add(this.textBoxNomProduit);
			this.tabPageProduit.Controls.Add(this.label5);
			this.tabPageProduit.Controls.Add(this.label6);
			this.tabPageProduit.Controls.Add(this.label7);
			this.tabPageProduit.Controls.Add(this.label8);
			this.tabPageProduit.Controls.Add(this.labelNumProduit);
			this.tabPageProduit.Controls.Add(this.buttonReinitialiserProduit);
			this.tabPageProduit.Controls.Add(this.comboBoxListeProduit);
			this.tabPageProduit.Controls.Add(this.labelTitreProduit);
			this.tabPageProduit.Location = new System.Drawing.Point(4, 22);
			this.tabPageProduit.Name = "tabPageProduit";
			this.tabPageProduit.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProduit.Size = new System.Drawing.Size(789, 541);
			this.tabPageProduit.TabIndex = 1;
			this.tabPageProduit.Text = "Produit";
			this.tabPageProduit.UseVisualStyleBackColor = true;
			// 
			// labelEuro
			// 
			this.labelEuro.AutoSize = true;
			this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEuro.Location = new System.Drawing.Point(441, 264);
			this.labelEuro.Name = "labelEuro";
			this.labelEuro.Size = new System.Drawing.Size(16, 18);
			this.labelEuro.TabIndex = 40;
			this.labelEuro.Text = "€";
			// 
			// labelNumProduitAffiche
			// 
			this.labelNumProduitAffiche.AutoSize = true;
			this.labelNumProduitAffiche.Location = new System.Drawing.Point(337, 90);
			this.labelNumProduitAffiche.Name = "labelNumProduitAffiche";
			this.labelNumProduitAffiche.Size = new System.Drawing.Size(0, 13);
			this.labelNumProduitAffiche.TabIndex = 39;
			// 
			// buttonSupprimerProduit
			// 
			this.buttonSupprimerProduit.Location = new System.Drawing.Point(490, 389);
			this.buttonSupprimerProduit.Name = "buttonSupprimerProduit";
			this.buttonSupprimerProduit.Size = new System.Drawing.Size(75, 23);
			this.buttonSupprimerProduit.TabIndex = 38;
			this.buttonSupprimerProduit.Text = "Supprimer";
			this.buttonSupprimerProduit.UseVisualStyleBackColor = true;
			this.buttonSupprimerProduit.Click += new System.EventHandler(this.buttonSupprimerProduit_Click);
			// 
			// buttonModifierProduit
			// 
			this.buttonModifierProduit.Location = new System.Drawing.Point(320, 389);
			this.buttonModifierProduit.Name = "buttonModifierProduit";
			this.buttonModifierProduit.Size = new System.Drawing.Size(75, 23);
			this.buttonModifierProduit.TabIndex = 37;
			this.buttonModifierProduit.Text = "Modifier";
			this.buttonModifierProduit.UseVisualStyleBackColor = true;
			this.buttonModifierProduit.Click += new System.EventHandler(this.buttonModifierProduit_Click);
			// 
			// buttonAjouterProduit
			// 
			this.buttonAjouterProduit.Location = new System.Drawing.Point(150, 389);
			this.buttonAjouterProduit.Name = "buttonAjouterProduit";
			this.buttonAjouterProduit.Size = new System.Drawing.Size(75, 23);
			this.buttonAjouterProduit.TabIndex = 36;
			this.buttonAjouterProduit.Text = "Ajouter";
			this.buttonAjouterProduit.UseVisualStyleBackColor = true;
			this.buttonAjouterProduit.Click += new System.EventHandler(this.buttonAjouterProduit_Click);
			// 
			// textBoxPrixProduit
			// 
			this.textBoxPrixProduit.Location = new System.Drawing.Point(340, 262);
			this.textBoxPrixProduit.Name = "textBoxPrixProduit";
			this.textBoxPrixProduit.Size = new System.Drawing.Size(95, 20);
			this.textBoxPrixProduit.TabIndex = 34;
			// 
			// textBoxQteProduit
			// 
			this.textBoxQteProduit.Location = new System.Drawing.Point(340, 227);
			this.textBoxQteProduit.Name = "textBoxQteProduit";
			this.textBoxQteProduit.Size = new System.Drawing.Size(95, 20);
			this.textBoxQteProduit.TabIndex = 33;
			// 
			// textBoxDescriptionP
			// 
			this.textBoxDescriptionP.Location = new System.Drawing.Point(340, 157);
			this.textBoxDescriptionP.Multiline = true;
			this.textBoxDescriptionP.Name = "textBoxDescriptionP";
			this.textBoxDescriptionP.Size = new System.Drawing.Size(213, 55);
			this.textBoxDescriptionP.TabIndex = 32;
			// 
			// textBoxNomProduit
			// 
			this.textBoxNomProduit.Location = new System.Drawing.Point(340, 122);
			this.textBoxNomProduit.Name = "textBoxNomProduit";
			this.textBoxNomProduit.Size = new System.Drawing.Size(213, 20);
			this.textBoxNomProduit.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(150, 265);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "Prix du produit :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(150, 230);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Quantité en stock :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(150, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 13);
			this.label7.TabIndex = 26;
			this.label7.Text = "Description du produit :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(150, 125);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Nom du produit :";
			// 
			// labelNumProduit
			// 
			this.labelNumProduit.AutoSize = true;
			this.labelNumProduit.Location = new System.Drawing.Point(150, 90);
			this.labelNumProduit.Name = "labelNumProduit";
			this.labelNumProduit.Size = new System.Drawing.Size(58, 13);
			this.labelNumProduit.TabIndex = 24;
			this.labelNumProduit.Text = "N°Produit :";
			// 
			// buttonReinitialiserProduit
			// 
			this.buttonReinitialiserProduit.Location = new System.Drawing.Point(153, 44);
			this.buttonReinitialiserProduit.Name = "buttonReinitialiserProduit";
			this.buttonReinitialiserProduit.Size = new System.Drawing.Size(75, 23);
			this.buttonReinitialiserProduit.TabIndex = 23;
			this.buttonReinitialiserProduit.Text = "Réinitialiser";
			this.buttonReinitialiserProduit.UseVisualStyleBackColor = true;
			this.buttonReinitialiserProduit.Click += new System.EventHandler(this.buttonReinitialiserProduit_Click);
			// 
			// comboBoxListeProduit
			// 
			this.comboBoxListeProduit.FormattingEnabled = true;
			this.comboBoxListeProduit.Location = new System.Drawing.Point(13, 46);
			this.comboBoxListeProduit.Name = "comboBoxListeProduit";
			this.comboBoxListeProduit.Size = new System.Drawing.Size(121, 21);
			this.comboBoxListeProduit.TabIndex = 21;
			this.comboBoxListeProduit.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeProduit_SelectedIndexChanged);
			// 
			// labelTitreProduit
			// 
			this.labelTitreProduit.AutoSize = true;
			this.labelTitreProduit.Location = new System.Drawing.Point(10, 17);
			this.labelTitreProduit.Name = "labelTitreProduit";
			this.labelTitreProduit.Size = new System.Drawing.Size(95, 13);
			this.labelTitreProduit.TabIndex = 0;
			this.labelTitreProduit.Text = "Liste des produits :";
			// 
			// tabPageClient
			// 
			this.tabPageClient.Controls.Add(this.pictureBox1);
			this.tabPageClient.Controls.Add(this.buttonSupprimerClient);
			this.tabPageClient.Controls.Add(this.buttonModifierClient);
			this.tabPageClient.Controls.Add(this.buttonAjouterClient);
			this.tabPageClient.Controls.Add(this.labelNumClientAffiche);
			this.tabPageClient.Controls.Add(this.labelNbCommandeAffiche);
			this.tabPageClient.Controls.Add(this.textBoxEmailClient);
			this.tabPageClient.Controls.Add(this.textBoxPseudoClient);
			this.tabPageClient.Controls.Add(this.textBoxTelClient);
			this.tabPageClient.Controls.Add(this.textBoxPrenomClient);
			this.tabPageClient.Controls.Add(this.textBoxNomClient);
			this.tabPageClient.Controls.Add(this.labelNBCommande);
			this.tabPageClient.Controls.Add(this.labelEmailClient);
			this.tabPageClient.Controls.Add(this.labelPseudoClient);
			this.tabPageClient.Controls.Add(this.labelTelClient);
			this.tabPageClient.Controls.Add(this.labelPrenomClient);
			this.tabPageClient.Controls.Add(this.labelNomClient);
			this.tabPageClient.Controls.Add(this.labelNumClient);
			this.tabPageClient.Controls.Add(this.buttonReinitialiser);
			this.tabPageClient.Controls.Add(this.buttonAfficher);
			this.tabPageClient.Controls.Add(this.comboBoxListeClient);
			this.tabPageClient.Controls.Add(this.labelTitreClient);
			this.tabPageClient.Location = new System.Drawing.Point(4, 22);
			this.tabPageClient.Name = "tabPageClient";
			this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageClient.Size = new System.Drawing.Size(789, 541);
			this.tabPageClient.TabIndex = 2;
			this.tabPageClient.Text = "Client";
			this.tabPageClient.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ProjetPPE.Properties.Resources.logogsb;
			this.pictureBox1.Location = new System.Drawing.Point(586, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(203, 134);
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// buttonSupprimerClient
			// 
			this.buttonSupprimerClient.Location = new System.Drawing.Point(490, 380);
			this.buttonSupprimerClient.Name = "buttonSupprimerClient";
			this.buttonSupprimerClient.Size = new System.Drawing.Size(75, 23);
			this.buttonSupprimerClient.TabIndex = 20;
			this.buttonSupprimerClient.Text = "Supprimer";
			this.buttonSupprimerClient.UseVisualStyleBackColor = true;
			this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimerClient_Click);
			// 
			// buttonModifierClient
			// 
			this.buttonModifierClient.Location = new System.Drawing.Point(320, 380);
			this.buttonModifierClient.Name = "buttonModifierClient";
			this.buttonModifierClient.Size = new System.Drawing.Size(75, 23);
			this.buttonModifierClient.TabIndex = 19;
			this.buttonModifierClient.Text = "Modifier";
			this.buttonModifierClient.UseVisualStyleBackColor = true;
			this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
			// 
			// buttonAjouterClient
			// 
			this.buttonAjouterClient.Location = new System.Drawing.Point(150, 380);
			this.buttonAjouterClient.Name = "buttonAjouterClient";
			this.buttonAjouterClient.Size = new System.Drawing.Size(75, 23);
			this.buttonAjouterClient.TabIndex = 18;
			this.buttonAjouterClient.Text = "Ajouter";
			this.buttonAjouterClient.UseVisualStyleBackColor = true;
			this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
			// 
			// labelNumClientAffiche
			// 
			this.labelNumClientAffiche.AutoSize = true;
			this.labelNumClientAffiche.Location = new System.Drawing.Point(333, 90);
			this.labelNumClientAffiche.Name = "labelNumClientAffiche";
			this.labelNumClientAffiche.Size = new System.Drawing.Size(0, 13);
			this.labelNumClientAffiche.TabIndex = 17;
			// 
			// labelNbCommandeAffiche
			// 
			this.labelNbCommandeAffiche.AutoSize = true;
			this.labelNbCommandeAffiche.Location = new System.Drawing.Point(333, 300);
			this.labelNbCommandeAffiche.Name = "labelNbCommandeAffiche";
			this.labelNbCommandeAffiche.Size = new System.Drawing.Size(0, 13);
			this.labelNbCommandeAffiche.TabIndex = 16;
			// 
			// textBoxEmailClient
			// 
			this.textBoxEmailClient.Location = new System.Drawing.Point(336, 262);
			this.textBoxEmailClient.Name = "textBoxEmailClient";
			this.textBoxEmailClient.Size = new System.Drawing.Size(213, 20);
			this.textBoxEmailClient.TabIndex = 15;
			// 
			// textBoxPseudoClient
			// 
			this.textBoxPseudoClient.Location = new System.Drawing.Point(336, 227);
			this.textBoxPseudoClient.Name = "textBoxPseudoClient";
			this.textBoxPseudoClient.Size = new System.Drawing.Size(213, 20);
			this.textBoxPseudoClient.TabIndex = 14;
			// 
			// textBoxTelClient
			// 
			this.textBoxTelClient.Location = new System.Drawing.Point(336, 192);
			this.textBoxTelClient.Name = "textBoxTelClient";
			this.textBoxTelClient.Size = new System.Drawing.Size(213, 20);
			this.textBoxTelClient.TabIndex = 13;
			// 
			// textBoxPrenomClient
			// 
			this.textBoxPrenomClient.Location = new System.Drawing.Point(336, 157);
			this.textBoxPrenomClient.Name = "textBoxPrenomClient";
			this.textBoxPrenomClient.Size = new System.Drawing.Size(213, 20);
			this.textBoxPrenomClient.TabIndex = 12;
			// 
			// textBoxNomClient
			// 
			this.textBoxNomClient.Location = new System.Drawing.Point(336, 122);
			this.textBoxNomClient.Name = "textBoxNomClient";
			this.textBoxNomClient.Size = new System.Drawing.Size(213, 20);
			this.textBoxNomClient.TabIndex = 11;
			// 
			// labelNBCommande
			// 
			this.labelNBCommande.AutoSize = true;
			this.labelNBCommande.Location = new System.Drawing.Point(150, 300);
			this.labelNBCommande.Name = "labelNBCommande";
			this.labelNBCommande.Size = new System.Drawing.Size(120, 13);
			this.labelNBCommande.TabIndex = 10;
			this.labelNBCommande.Text = "Nombre de commande :";
			// 
			// labelEmailClient
			// 
			this.labelEmailClient.AutoSize = true;
			this.labelEmailClient.Location = new System.Drawing.Point(150, 265);
			this.labelEmailClient.Name = "labelEmailClient";
			this.labelEmailClient.Size = new System.Drawing.Size(81, 13);
			this.labelEmailClient.TabIndex = 9;
			this.labelEmailClient.Text = "Email du client :";
			// 
			// labelPseudoClient
			// 
			this.labelPseudoClient.AutoSize = true;
			this.labelPseudoClient.Location = new System.Drawing.Point(150, 230);
			this.labelPseudoClient.Name = "labelPseudoClient";
			this.labelPseudoClient.Size = new System.Drawing.Size(92, 13);
			this.labelPseudoClient.TabIndex = 8;
			this.labelPseudoClient.Text = "Pseudo du client :";
			// 
			// labelTelClient
			// 
			this.labelTelClient.AutoSize = true;
			this.labelTelClient.Location = new System.Drawing.Point(150, 195);
			this.labelTelClient.Name = "labelTelClient";
			this.labelTelClient.Size = new System.Drawing.Size(71, 13);
			this.labelTelClient.TabIndex = 7;
			this.labelTelClient.Text = "Tèl du client :";
			// 
			// labelPrenomClient
			// 
			this.labelPrenomClient.AutoSize = true;
			this.labelPrenomClient.Location = new System.Drawing.Point(150, 160);
			this.labelPrenomClient.Name = "labelPrenomClient";
			this.labelPrenomClient.Size = new System.Drawing.Size(92, 13);
			this.labelPrenomClient.TabIndex = 6;
			this.labelPrenomClient.Text = "Prénom du client :";
			// 
			// labelNomClient
			// 
			this.labelNomClient.AutoSize = true;
			this.labelNomClient.Location = new System.Drawing.Point(150, 125);
			this.labelNomClient.Name = "labelNomClient";
			this.labelNomClient.Size = new System.Drawing.Size(78, 13);
			this.labelNomClient.TabIndex = 5;
			this.labelNomClient.Text = "Nom du client :";
			// 
			// labelNumClient
			// 
			this.labelNumClient.AutoSize = true;
			this.labelNumClient.Location = new System.Drawing.Point(150, 90);
			this.labelNumClient.Name = "labelNumClient";
			this.labelNumClient.Size = new System.Drawing.Size(51, 13);
			this.labelNumClient.TabIndex = 4;
			this.labelNumClient.Text = "N°Client :";
			// 
			// buttonReinitialiser
			// 
			this.buttonReinitialiser.Location = new System.Drawing.Point(249, 44);
			this.buttonReinitialiser.Name = "buttonReinitialiser";
			this.buttonReinitialiser.Size = new System.Drawing.Size(75, 23);
			this.buttonReinitialiser.TabIndex = 3;
			this.buttonReinitialiser.Text = "Réinitialiser";
			this.buttonReinitialiser.UseVisualStyleBackColor = true;
			this.buttonReinitialiser.Click += new System.EventHandler(this.buttonReinitialiser_Click);
			// 
			// buttonAfficher
			// 
			this.buttonAfficher.Location = new System.Drawing.Point(153, 44);
			this.buttonAfficher.Name = "buttonAfficher";
			this.buttonAfficher.Size = new System.Drawing.Size(75, 23);
			this.buttonAfficher.TabIndex = 2;
			this.buttonAfficher.Text = "Afficher";
			this.buttonAfficher.UseVisualStyleBackColor = true;
			this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
			// 
			// comboBoxListeClient
			// 
			this.comboBoxListeClient.FormattingEnabled = true;
			this.comboBoxListeClient.Location = new System.Drawing.Point(13, 46);
			this.comboBoxListeClient.Name = "comboBoxListeClient";
			this.comboBoxListeClient.Size = new System.Drawing.Size(121, 21);
			this.comboBoxListeClient.TabIndex = 1;
			this.comboBoxListeClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeClient_SelectedIndexChanged);
			// 
			// labelTitreClient
			// 
			this.labelTitreClient.AutoSize = true;
			this.labelTitreClient.Location = new System.Drawing.Point(9, 17);
			this.labelTitreClient.Name = "labelTitreClient";
			this.labelTitreClient.Size = new System.Drawing.Size(88, 13);
			this.labelTitreClient.TabIndex = 0;
			this.labelTitreClient.Text = "Liste des clients :";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "GSB Admin";
			this.tabControl1.ResumeLayout(false);
			this.tabPageCommande.ResumeLayout(false);
			this.tabPageCommande.PerformLayout();
			this.groupBoxContenu.ResumeLayout(false);
			this.groupBoxContenu.PerformLayout();
			this.panelStatutC.ResumeLayout(false);
			this.panelStatutC.PerformLayout();
			this.panelModeP.ResumeLayout(false);
			this.panelModeP.PerformLayout();
			this.tabPageProduit.ResumeLayout(false);
			this.tabPageProduit.PerformLayout();
			this.tabPageClient.ResumeLayout(false);
			this.tabPageClient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCommande;
        private System.Windows.Forms.TabPage tabPageProduit;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.Label labelTitreCommande;
        private System.Windows.Forms.TextBox textBoxFiltre;
        private System.Windows.Forms.ListBox listBoxCommande;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Label labelNCommande;
        private System.Windows.Forms.Label labelNClient;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
		private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxNClient;
        private System.Windows.Forms.Label labelStatutC;
        private System.Windows.Forms.Label labelModeP;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.GroupBox groupBoxContenu;
        private System.Windows.Forms.TextBox textBoxDescriptionC;
        private System.Windows.Forms.Label labelDescriptionC;
        private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.RadioButton radioButtonStatutCExpediee;
		private System.Windows.Forms.RadioButton radioButtonStatutCEnCours;
		private System.Windows.Forms.Panel panelStatutC;
		private System.Windows.Forms.Panel panelModeP;
		private System.Windows.Forms.RadioButton radioButtonModePCB;
		private System.Windows.Forms.RadioButton radioButtonModePCheque;
        private System.Windows.Forms.Label labelNFacture;
        private System.Windows.Forms.TextBox textBoxNFacture;
        private System.Windows.Forms.TextBox textBoxDateC;
        private System.Windows.Forms.Label labelDateC;
        private System.Windows.Forms.Label label1Commande;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelCp;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.Label labelInfoDate;
		private System.Windows.Forms.Label labelTitreClient;
		private System.Windows.Forms.ComboBox comboBoxListeClient;
		private System.Windows.Forms.Label labelNumClientAffiche;
		private System.Windows.Forms.Label labelNbCommandeAffiche;
		private System.Windows.Forms.TextBox textBoxEmailClient;
		private System.Windows.Forms.TextBox textBoxPseudoClient;
		private System.Windows.Forms.TextBox textBoxTelClient;
		private System.Windows.Forms.TextBox textBoxPrenomClient;
		private System.Windows.Forms.TextBox textBoxNomClient;
		private System.Windows.Forms.Label labelNBCommande;
		private System.Windows.Forms.Label labelEmailClient;
		private System.Windows.Forms.Label labelPseudoClient;
		private System.Windows.Forms.Label labelTelClient;
		private System.Windows.Forms.Label labelPrenomClient;
		private System.Windows.Forms.Label labelNomClient;
		private System.Windows.Forms.Label labelNumClient;
		private System.Windows.Forms.Button buttonReinitialiser;
		private System.Windows.Forms.Button buttonAfficher;
		private System.Windows.Forms.Button buttonSupprimerClient;
		private System.Windows.Forms.Button buttonModifierClient;
		private System.Windows.Forms.Button buttonAjouterClient;
		private System.Windows.Forms.Button buttonSupprimerProduit;
		private System.Windows.Forms.Button buttonModifierProduit;
		private System.Windows.Forms.Button buttonAjouterProduit;
		private System.Windows.Forms.TextBox textBoxPrixProduit;
		private System.Windows.Forms.TextBox textBoxQteProduit;
		private System.Windows.Forms.TextBox textBoxDescriptionP;
		private System.Windows.Forms.TextBox textBoxNomProduit;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelNumProduit;
		private System.Windows.Forms.Button buttonReinitialiserProduit;
		private System.Windows.Forms.ComboBox comboBoxListeProduit;
		private System.Windows.Forms.Label labelTitreProduit;
		private System.Windows.Forms.Label labelNumProduitAffiche;
		private System.Windows.Forms.Label labelEuro;
		private System.Windows.Forms.PictureBox pictureBox1;
    }
}

