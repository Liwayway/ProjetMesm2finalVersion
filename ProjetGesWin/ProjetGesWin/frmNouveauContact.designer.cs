namespace ProjetGesWin
{
    partial class frmNouveauContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouveauContact));
            this.gbxIdentite = new System.Windows.Forms.GroupBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cbxFonction = new System.Windows.Forms.ComboBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.gbxIdentite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxIdentite
            // 
            this.gbxIdentite.Controls.Add(this.lblPhoto);
            this.gbxIdentite.Controls.Add(this.picContact);
            this.gbxIdentite.Controls.Add(this.lblEmail);
            this.gbxIdentite.Controls.Add(this.lblTelephone);
            this.gbxIdentite.Controls.Add(this.lblPrenom);
            this.gbxIdentite.Controls.Add(this.txtEmail);
            this.gbxIdentite.Controls.Add(this.txtTelephone);
            this.gbxIdentite.Controls.Add(this.txtPrenom);
            this.gbxIdentite.Controls.Add(this.txtNom);
            this.gbxIdentite.Controls.Add(this.lblNom);
            this.gbxIdentite.Location = new System.Drawing.Point(9, 45);
            this.gbxIdentite.Margin = new System.Windows.Forms.Padding(2);
            this.gbxIdentite.Name = "gbxIdentite";
            this.gbxIdentite.Padding = new System.Windows.Forms.Padding(2);
            this.gbxIdentite.Size = new System.Drawing.Size(571, 212);
            this.gbxIdentite.TabIndex = 0;
            this.gbxIdentite.TabStop = false;
            this.gbxIdentite.Text = "Identité";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(370, 173);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(179, 13);
            this.lblPhoto.TabIndex = 9;
            this.lblPhoto.Text = "DoubleClic sur la photo pour modifier";
            // 
            // picContact
            // 
            this.picContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picContact.Image = ((System.Drawing.Image)(resources.GetObject("picContact.Image")));
            this.picContact.InitialImage = ((System.Drawing.Image)(resources.GetObject("picContact.InitialImage")));
            this.picContact.Location = new System.Drawing.Point(374, 27);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(175, 143);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContact.TabIndex = 8;
            this.picContact.TabStop = false;
            this.picContact.Click += new System.EventHandler(this.picContact_Click_1);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 165);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(16, 124);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(16, 75);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 162);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(94, 119);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(222, 20);
            this.txtTelephone.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(94, 71);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(222, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNom.Location = new System.Drawing.Point(94, 27);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(222, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(16, 31);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // cbxFonction
            // 
            this.cbxFonction.FormattingEnabled = true;
            this.cbxFonction.Location = new System.Drawing.Point(110, 283);
            this.cbxFonction.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFonction.Name = "cbxFonction";
            this.cbxFonction.Size = new System.Drawing.Size(213, 21);
            this.cbxFonction.TabIndex = 1;
            this.cbxFonction.DropDown += new System.EventHandler(this.cbxFonction_DropDown);
            this.cbxFonction.SelectedIndexChanged += new System.EventHandler(this.cbxFonction_SelectedIndexChanged);
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(34, 286);
            this.lblFonction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(54, 13);
            this.lblFonction.TabIndex = 2;
            this.lblFonction.Text = "Fonction :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(420, 327);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 24);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(512, 327);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(77, 24);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(26, 15);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 5;
            this.lblClient.Text = "Client :";
            this.lblClient.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtActivite
            // 
            this.txtActivite.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtActivite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivite.Location = new System.Drawing.Point(159, 15);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.ReadOnly = true;
            this.txtActivite.Size = new System.Drawing.Size(399, 13);
            this.txtActivite.TabIndex = 7;
            this.txtActivite.Text = "Raison Sociale";
            // 
            // txtClient
            // 
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClient.Location = new System.Drawing.Point(71, 15);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(82, 13);
            this.txtClient.TabIndex = 6;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // frmNouveauContact
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtActivite);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFonction);
            this.Controls.Add(this.cbxFonction);
            this.Controls.Add(this.gbxIdentite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNouveauContact";
            this.ShowIcon = false;
            this.Text = "Saisie nouveau Contact";
            this.Load += new System.EventHandler(this.frmNouveauContact_Load);
            this.gbxIdentite.ResumeLayout(false);
            this.gbxIdentite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIdentite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox cbxFonction;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.Label lblPhoto;
    }
}

