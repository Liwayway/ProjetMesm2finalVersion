using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetGesWin
{
    public partial class frmNouveauClient : ProjetGesWin.frmClientParent
    {
        public frmNouveauClient()
        {
            InitializeComponent();
        }


        private Int32 iContact;


        private void frmNouveauClient_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Créer une référence d'objets MClients
            MClients nouveauClient = new MClients();

            //Affectation des variables/propriétés
            nouveauClient.NumClient = Int32.Parse(base.txtBoxNv.Text.Trim());
            nouveauClient.RaisonSociale = base.txtBoxRs.Text;
            nouveauClient.AdresseClient = base.txtBoxAd.Text;
            nouveauClient.AdresseClient2 = base.txtBoxAd2.Text;
            nouveauClient.CodePostal = base.txtBoxCp.Text;
            nouveauClient.Ville = base.txtBoxVil.Text;
            nouveauClient.TelephoneClient = base.txtBoxTel.Text;
            nouveauClient.ClientPrive = base.chkBoxPv2.Checked;
            nouveauClient.Effectif = Int32.Parse(base.txtBoxEff.Text.Trim());
            nouveauClient.ChiffreAffaires = Int32.Parse(base.txtBoxCa.Text.Trim());

            //Numéro du client, qui le définit ?
            // Est ce que le numéro client = rang du client +1 (pour pas avoir de client zéro) ?

            nouveauClient.IClient++;

            /*Je ne sais pas comment faire pour les combobox
             * Concernant nouveauClient.Activite et nouveauClient.Nature
            */

            
             //ajouter la référence d'objet MClients dans la collection
                Donnees.arrayClients.Add(nouveauClient);
            // incrémentation compteur de clients
                MClients.NClients++;
            
            
            frmListeClients frmListe = new frmListeClients();


           //00h j'ai interverti afficheclient avec show
            frmListe.afficheClient();
            frmListe.Show();
            this.Close();
            








        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNv_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Un contact doit appartenir à un client or on nous demande d'ajouter un contact à un client 
        /// qui n'existe pas encore, comment faire ?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContacts_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau contact Commercial
            frmNouveauContact frmNouveau = new frmNouveauContact(new MClients());

            // affichage en modal et contrôle que l'utilisateur
            // en sort par OK
            if (frmNouveau.ShowDialog() == DialogResult.OK)
            {
                // recherche rang du contact saisi
                this.iContact = MCommercial.NContacts - 1;
            }   

    
        }
    }
}
