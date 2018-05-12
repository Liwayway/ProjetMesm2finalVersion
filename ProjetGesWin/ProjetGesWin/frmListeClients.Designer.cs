namespace ProjetGesWin
{
    partial class frmListeClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxRecherche = new System.Windows.Forms.GroupBox();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtbRaisonSociale = new System.Windows.Forms.TextBox();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.lblTexte = new System.Windows.Forms.Label();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.gbxRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRecherche
            // 
            this.gbxRecherche.Controls.Add(this.btnTous);
            this.gbxRecherche.Controls.Add(this.btnRechercher);
            this.gbxRecherche.Controls.Add(this.txtbRaisonSociale);
            this.gbxRecherche.Controls.Add(this.lblRaisonSociale);
            this.gbxRecherche.Location = new System.Drawing.Point(38, 40);
            this.gbxRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRecherche.Name = "gbxRecherche";
            this.gbxRecherche.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRecherche.Size = new System.Drawing.Size(448, 67);
            this.gbxRecherche.TabIndex = 2;
            this.gbxRecherche.TabStop = false;
            this.gbxRecherche.Text = "Recherche";
            // 
            // btnTous
            // 
            this.btnTous.Enabled = false;
            this.btnTous.Location = new System.Drawing.Point(391, 31);
            this.btnTous.Margin = new System.Windows.Forms.Padding(2);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(44, 23);
            this.btnTous.TabIndex = 3;
            this.btnTous.Text = "&Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(318, 31);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(68, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtbRaisonSociale
            // 
            this.txtbRaisonSociale.Location = new System.Drawing.Point(104, 33);
            this.txtbRaisonSociale.Margin = new System.Windows.Forms.Padding(2);
            this.txtbRaisonSociale.Name = "txtbRaisonSociale";
            this.txtbRaisonSociale.Size = new System.Drawing.Size(210, 20);
            this.txtbRaisonSociale.TabIndex = 1;
            this.txtbRaisonSociale.TextChanged += new System.EventHandler(this.txtbRaisonSociale_TextChanged);
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(4, 33);
            this.lblRaisonSociale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSociale.TabIndex = 0;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // grdListe
            // 
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Location = new System.Drawing.Point(38, 127);
            this.grdListe.Margin = new System.Windows.Forms.Padding(2);
            this.grdListe.Name = "grdListe";
            this.grdListe.ReadOnly = true;
            this.grdListe.RowTemplate.Height = 24;
            this.grdListe.Size = new System.Drawing.Size(562, 201);
            this.grdListe.TabIndex = 3;
            this.grdListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListe_CellContentClick_1);
            this.grdListe.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListe_CellContentClick);
            this.grdListe.DoubleClick += new System.EventHandler(this.grdListe_DoubleClick);
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexte.Location = new System.Drawing.Point(35, 393);
            this.lblTexte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(177, 13);
            this.lblTexte.TabIndex = 6;
            this.lblTexte.Text = "Double-clic pour consulter / modifier";
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.Location = new System.Drawing.Point(274, 388);
            this.btnNouveauClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(106, 23);
            this.btnNouveauClient.TabIndex = 7;
            this.btnNouveauClient.Text = "&Nouveau Client";
            this.btnNouveauClient.UseVisualStyleBackColor = true;
            this.btnNouveauClient.Click += new System.EventHandler(this.btnNouveauClient_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(406, 388);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(80, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFermer.Location = new System.Drawing.Point(535, 388);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(65, 23);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnNouveauClient);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.grdListe);
            this.Controls.Add(this.gbxRecherche);
            this.Name = "frmListeClients";
            this.ShowIcon = false;
            this.Text = "Liste des Clients";
            this.Load += new System.EventHandler(this.frmListeClients2_Load);
            this.gbxRecherche.ResumeLayout(false);
            this.gbxRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRecherche;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtbRaisonSociale;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.DataGridView grdListe;
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.Button btnNouveauClient;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
    }
}