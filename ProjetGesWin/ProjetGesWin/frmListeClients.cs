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
    public partial class frmListeClients : Form
    {
        /// <summary>
        /// On définit le rang du Client traité
        /// </summary>
         private Int32 iClient;

        public frmListeClients()
        {
            InitializeComponent();
        }

        

        private void frmListeClients2_Load(object sender, EventArgs e)
        {

        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            //On instancie un form de saisie en mode modal
            frmNouveauClient frmAjout;
            frmAjout = new frmNouveauClient();


            // Si on sort de la saisie par OK, regenere l'affichage du datagrid
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {

                this.afficheClient();

                
            }
            //00h03 si je rajoute this.Close(); ça fait quoi ? YIHAAA C'est ce qui regle le pb du deuxieme form qui s'ouvre sans rien
            //avec le changement dans bouton ok de frmNouveauClient :
            //00h j'ai interverti afficheclient avec show
            this.Close();
        }

        /// <summary>
        /// Supprime le client sélectionné dans la datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            grdListe.Rows.Remove(grdListe.CurrentRow);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// la recherche effectue un changement dans l'affichage du DataGriedView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            // si l'utilisateur tape une raison sociale ou le début du mot, il verra apparaître les entreprises correspondantes
            if (this.txtbRaisonSociale.Text != null)
            {
                ((DataView)(this.grdListe.DataSource)).RowFilter = "Raison sociale like '%" + this.txtbRaisonSociale.Text + "%'";
            }

        }


        /// <summary>
        /// le bouton "tous" permet de récupérer l'affichage de base dans le DataGriedView avant la recherche spécifique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTous_Click(object sender, EventArgs e)
        {
            // le bouton "tous" est grisé dès l'ouverture de la fenêtre
            this.btnTous.Enabled = false;
            // si l'utilisateur tape une recherche, le bouton "tous" est dégrisé
            if (this.txtbRaisonSociale.Text != null)
            {
                this.btnTous.Enabled = true;
            }

            // à partir du moment où il n'y a pas de recherche, tous les clients sont affichés
            this.txtbRaisonSociale.Text = null;
            ((DataView)(this.grdListe.DataSource)).RowFilter = null;

        }

        private void txtbRaisonSociale_TextChanged(object sender, EventArgs e)
        {
            if (this.txtbRaisonSociale.Text != null)
            {
                ((DataView)(this.grdListe.DataSource)).RowFilter = "Raison sociale like '%" + this.txtbRaisonSociale.Text + "%'";
            }
        }

       private void grdListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        /// <summary>
        /// Permet d'afficher dans la datagridView les clients ajoutés
        /// On définit une dataTable qui sera alimentée par les données de nos clients
        /// Cette procédure sera ensuite appelée au niveau dès le chargement du formulaire
        /// (constructeur du form ou evenement load)
        /// </summary>
        public void afficheClient()
        {

            //DataTable permettant de recopier les clients stockés dans la collection
            DataTable dt = new DataTable();
            // Ligne de la dataTable
            DataRow dr;
            //Variable de boucle
            int j;


            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code postal", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Privé", typeof(System.Boolean)));
            dt.Columns.Add(new DataColumn("Activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));


            // boucle de remplissage de la DataTable à partir de la collection            
            for (j = 0; j < Donnees.arrayClients.Count; j++)
            {
                // Seb : pourquoi déjà on instancie ici ? Dans l'exo7 on ne le fait pas (en tous cas pas là)
                MClients client = (MClients)Donnees.getClientById(j);
                //Instanciation de la datarow
                dr = dt.NewRow();
                //Affectation des colonnes
                //Code proposé par Seb
                //Dans l'exo7 voici la syntaxe :
                //dr[0] = ((MClients)(Donnees.ArrayClients[j])).RaisonSociale;
                //etc
                dr[0] = client.RaisonSociale;
                dr[1] = client.Ville;
                dr[2] = client.CodePostal;
                dr[3] = client.ClientPrive;
                dr[4] = client.Activite;
                dr[5] = client.Nature;
                //Ajout de la ligne à la dataTable
                dt.Rows.Add(dr);
            }
            // détermine l'origine des données à afficher dans la datagriedview
            this.grdListe.DataSource = dt.DefaultView;
            // rafraichi le datagriedview
            this.grdListe.Refresh();
            dt = null; // utile ?
            dr = null; // utilité ?


           

        }

        private void grdListe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void grdListe_DoubleClick(object sender, EventArgs e)
        {
            Int32 iClient;
            iClient = this.grdListe.CurrentRow.Index;

            //Code suivant mis en commentaire : pourquoi ajouter ça ?
            
            // instancie un objet client vers le form de consultation client d'origine dans la collection
            // Code proposé par Seb
            //Dans l'exo 7
            // MClients leClient = Donnees.ArrayClients[iClient] as MClients
            MClients leClient = Donnees.getClientById(iClient) as MClients;
            // instancie le form "Nouveau Contact" qui correspond à la création du contact
            
            frmConsultationClient frmConsultation = new frmConsultationClient(leClient);
            // affiche le form de la création de contact en modal
            frmConsultation.ShowDialog();
            // rafaichit la datagriedview quand le form est fermé
            this.afficheClient();
            
        }
    }
}
