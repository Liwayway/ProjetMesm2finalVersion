using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetGesWin
{
    public partial class frmConsultationClient : ProjetGesWin.frmClientParent
    {
        
        //Cette fenetre doit connaitre la reference du client sur lequel elle doit travailler des son ouverture,
        //càd dès l'instanciation du formulaire


        //Ajout d'un membre de niveau classe (dans l'exo en private)
        protected MClients leClient;

        private int iContact;

        /// <summary>
        /// On initialise la référence de l'objet MClient
        /// Le parametre du constructeur sera donc la référence de l'objet Client
        /// à traiter dans ce formulaire
        /// </summary>
        /// <param name="client"></param>
        public frmConsultationClient(MClients client)
        {
            // on crée une référence d'objet stagiaire pointant vers le stagiaire d'origine de la collection
            this.leClient = client;
            InitializeComponent();
        }



        /// <summary>
        /// On recopie les membres des données du client dans 
        /// les champs d'affichage
        /// On mettra le code dans la procédure d'affichageClient
        /// 
        /// Au démarrage, afficher le client reçu sur le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsultationClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau contact Commercial
            frmNouveauContact frmNouveau = new frmNouveauContact(leClient);

            // affichage en modal et contrôle que l'utilisateur
            // en sort par OK
            if (frmNouveau.ShowDialog() == DialogResult.OK)
            {
                // recherche rang du contact saisi
                this.iContact = MCommercial.NContacts - 1;
            }
            this.Close();
        }

        /// <summary>
        /// Procédure d'affichage avec comme paramètre
        /// la référence du client à afficher
        /// </summary>
        protected void afficheClient(MClients leClient)
        {
            // this.leClient
            txtBoxNv.Text = leClient.NumClient.ToString();
            txtBoxRs.Text = leClient.RaisonSociale.ToString();
            txtBoxAd.Text = leClient.AdresseClient;
            txtBoxAd2.Text = leClient.AdresseClient2;
            txtBoxCp.Text = leClient.CodePostal;
            txtBoxVil.Text = leClient.Ville;
            try
            {
                txtBoxTel.Text = leClient.TelephoneClient.ToString();
            }
            catch (TelephoneInvalide)
            {
                if (!(txtBoxTel.Text.Length == 10))
                {
                    MessageBox.Show("Vous devez rentrer dix chiffres, pas plus, pas moins.");
                }
            }
           
            chkBoxPv2.Checked = leClient.ClientPrive;
            txtBoxEff.Text = leClient.Effectif.ToString();
            txtBoxCa.Text = leClient.ChiffreAffaires.ToString();
            //Gné, là ce sont des combobox à modifier

            txtActivite.Text = leClient.Activite;
            txtNature.Text = leClient.Nature;
           
        }


        public void afficheContact()
        {
            DataTable dataContact = new DataTable();
            DataRow dr;
            int j;
            dataContact.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dataContact.Columns.Add(new DataColumn("Prenom", typeof(System.String)));
            dataContact.Columns.Add(new DataColumn("Telephone", typeof(System.Int32)));
            dataContact.Columns.Add(new DataColumn("Email", typeof(System.String)));
            dataContact.Columns.Add(new DataColumn("Fonction", typeof(System.String)));
            // boucle de remplissage de la DataTable à partir de la collection

            // à ameliorer: on va chercher dans Donnees la liste des commerciaux correspondants
            // à ceux du client. Puis on parcourt cette nouvelle liste pour créer les dataContact
            // ArrayList commerciaux = Donnees.getCommercialByumClient(leClient.NumClient);
            // for (j=0; j < commerciaux.Count; j++) 

            for (j = 0; j < Donnees.arrayCommercial.Count; j++)
            {
                dr = dataContact.NewRow();
                MCommercial mCommercial = (MCommercial)(Donnees.getCommercialById(j));
                if (mCommercial.NumClient == this.leClient.NumClient)
                {
                    dr[0] = mCommercial.NomContact;
                    dr[1] = mCommercial.PrenomContact;
                    dr[2] = mCommercial.TelephoneContact;
                    dr[3] = mCommercial.Email;
                    dr[4] = mCommercial.Fonction;

                    dataContact.Rows.Add(dr);
                }
            }
            // détermine l'origine des données à afficher dans la datagriedview
            this.grdContact.DataSource = dataContact.DefaultView;
            // rafraichi le datagriedview
            this.grdContact.Refresh();
        }
        
        private void txtBoxCp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            frmModifierClient clientAModifier = new frmModifierClient();
            clientAModifier.Show();

        }

        private void txtActivite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
