using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGesWin
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private Int32 iClient;

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterNouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau client
            frmNouveauClient frmNouveau = new frmNouveauClient();

            // affichage en modal et contrôle que l'utilisateur
            // en sort par OK
            if (frmNouveau.ShowDialog() == DialogResult.OK)
            {
                // recherche rang du client saisi
                this.iClient = MClients.NClients - 1;
                
                

            }
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau client
            frmListeClients frmNouveau = new frmListeClients();
            frmNouveau.Show();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
