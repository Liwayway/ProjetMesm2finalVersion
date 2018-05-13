namespace ProjetGesWin
{
    partial class frmConsultationClient
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
            this.lblContacts = new System.Windows.Forms.Label();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.txtNature = new System.Windows.Forms.TextBox();
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.gpBoxIdNv.SuspendLayout();
            this.gpBoxCarNv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.ReadOnly = true;
            // 
            // txtBoxCp
            // 
            this.txtBoxCp.ReadOnly = true;
            this.txtBoxCp.TabIndex = 9;
            this.txtBoxCp.TextChanged += new System.EventHandler(this.txtBoxCp_TextChanged);
            // 
            // txtBoxVil
            // 
            this.txtBoxVil.ReadOnly = true;
            this.txtBoxVil.TabIndex = 10;
            // 
            // txtBoxAd2
            // 
            this.txtBoxAd2.ReadOnly = true;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.ReadOnly = true;
            // 
            // txtBoxRs
            // 
            this.txtBoxRs.ReadOnly = true;
            // 
            // txtBoxNv
            // 
            this.txtBoxNv.ReadOnly = true;
            // 
            // gpBoxCarNv
            // 
            this.gpBoxCarNv.Controls.Add(this.txtNature);
            this.gpBoxCarNv.Controls.Add(this.txtActivite);
            this.gpBoxCarNv.Controls.SetChildIndex(this.chkBoxPv2, 0);
            this.gpBoxCarNv.Controls.SetChildIndex(this.cbBoxAct, 0);
            this.gpBoxCarNv.Controls.SetChildIndex(this.cbBoxNat, 0);
            this.gpBoxCarNv.Controls.SetChildIndex(this.txtBoxEff, 0);
            this.gpBoxCarNv.Controls.SetChildIndex(this.txtBoxCa, 0);
            this.gpBoxCarNv.Controls.SetChildIndex(this.txtActivite, 0);
            this.gpBoxCarNv.Controls.SetChildIndex(this.txtNature, 0);
            // 
            // txtBoxCa
            // 
            this.txtBoxCa.ReadOnly = true;
            // 
            // txtBoxEff
            // 
            this.txtBoxEff.ReadOnly = true;
            // 
            // cbBoxNat
            // 
            this.cbBoxNat.Location = new System.Drawing.Point(299, 102);
            this.cbBoxNat.Visible = false;
            // 
            // cbBoxAct
            // 
            this.cbBoxAct.Visible = false;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Location = new System.Drawing.Point(22, 437);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(49, 13);
            this.lblContacts.TabIndex = 3;
            this.lblContacts.Text = "Contacts";
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(322, 570);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(96, 23);
            this.btnModifierClient.TabIndex = 5;
            this.btnModifierClient.Text = "Modifier Client";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.Location = new System.Drawing.Point(424, 570);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(109, 23);
            this.btnNouveauContact.TabIndex = 6;
            this.btnNouveauContact.Text = "Nouveau Contact";
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            this.btnNouveauContact.Click += new System.EventHandler(this.btnNouveauContact_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(539, 570);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(57, 23);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // txtActivite
            // 
            this.txtActivite.Location = new System.Drawing.Point(96, 103);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.ReadOnly = true;
            this.txtActivite.Size = new System.Drawing.Size(121, 20);
            this.txtActivite.TabIndex = 9;
            this.txtActivite.TextChanged += new System.EventHandler(this.txtActivite_TextChanged);
            // 
            // txtNature
            // 
            this.txtNature.Location = new System.Drawing.Point(299, 103);
            this.txtNature.Name = "txtNature";
            this.txtNature.ReadOnly = true;
            this.txtNature.Size = new System.Drawing.Size(121, 20);
            this.txtNature.TabIndex = 10;
            // 
            // grdContact
            // 
            this.grdContact.AllowUserToAddRows = false;
            this.grdContact.AllowUserToDeleteRows = false;
            this.grdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContact.Location = new System.Drawing.Point(25, 453);
            this.grdContact.Name = "grdContact";
            this.grdContact.ReadOnly = true;
            this.grdContact.Size = new System.Drawing.Size(636, 92);
            this.grdContact.TabIndex = 4;
            this.grdContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmConsultationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(721, 615);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.grdContact);
            this.Controls.Add(this.lblContacts);
            this.Name = "frmConsultationClient";
            this.ShowIcon = false;
            this.Text = "Consultation Client";
            this.Load += new System.EventHandler(this.frmConsultationClient_Load);
            this.Controls.SetChildIndex(this.lblContacts, 0);
            this.Controls.SetChildIndex(this.grdContact, 0);
            this.Controls.SetChildIndex(this.btnModifierClient, 0);
            this.Controls.SetChildIndex(this.btnNouveauContact, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.gpBoxIdNv, 0);
            this.Controls.SetChildIndex(this.gpBoxCarNv, 0);
            this.gpBoxIdNv.ResumeLayout(false);
            this.gpBoxIdNv.PerformLayout();
            this.gpBoxCarNv.ResumeLayout(false);
            this.gpBoxCarNv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox txtNature;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.DataGridView grdContact;
    }
}
