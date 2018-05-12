namespace ProjetGesWin
{
    partial class frmNouveauClient
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gpBoxIdNv.SuspendLayout();
            this.gpBoxCarNv.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxCp
            // 
            this.txtBoxCp.TabIndex = 9;
            // 
            // txtBoxVil
            // 
            this.txtBoxVil.TabIndex = 10;
            // 
            // txtBoxNv
            // 
            this.txtBoxNv.TextChanged += new System.EventHandler(this.txtBoxNv_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(430, 473);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(47, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(483, 473);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(69, 23);
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(558, 473);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(67, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmNouveauClient
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(699, 520);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnOK);
            this.Name = "frmNouveauClient";
            this.Text = "Saisie Nouveau Client";
            this.Load += new System.EventHandler(this.frmNouveauClient_Load);
            this.Controls.SetChildIndex(this.gpBoxIdNv, 0);
            this.Controls.SetChildIndex(this.gpBoxCarNv, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnContacts, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.gpBoxIdNv.ResumeLayout(false);
            this.gpBoxIdNv.PerformLayout();
            this.gpBoxCarNv.ResumeLayout(false);
            this.gpBoxCarNv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
