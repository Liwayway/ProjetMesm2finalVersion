﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace ProjetGesWin
{
    public partial class frmNouveauContact : Form
    {
        private MClients leClient;
        
        public frmNouveauContact(MClients client)
        {
            InitializeComponent();
            this.leClient = client;
        }

        private void frmNouveauContact_Load(object sender, EventArgs e)
        {
            this.txtClient.Text = this.leClient.NumClient.ToString();
            this.txtActivite.Text = this.leClient.RaisonSociale;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            
            //Ajout Nouveau Contact
            MCommercial nouveauContact = new MCommercial();
            nouveauContact.NumClient = this.leClient.NumClient;
            nouveauContact.NomContact = this.txtNom.Text;
            nouveauContact.PrenomContact = this.txtPrenom.Text;
            nouveauContact.TelephoneContact = this.txtTelephone.Text;
            nouveauContact.PhotoContact = this.picContact.Image;

            //Controle de la saisie de l'email
            nouveauContact.Email = this.txtEmail.Text;

            // affecter la propriété  nouveauContact.Fonction = 



            // ajouter la référence d'objets MCommercial dans la collection

            Donnees.arrayCommercial.Add(nouveauContact);
            // incrémentation du compteur de contacts
            MCommercial.NContacts += 1;
            // fermeture de la boite de dialogue par validation
            //this.DialogResult = DialogResult.OK;
            frmConsultationClient nouveauCommercial = new frmConsultationClient(leClient);
            nouveauCommercial.Show();
            nouveauCommercial.afficheContact();
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void picContact_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void picContact_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picContact.Image = new Bitmap(open.FileName);
                // image file path  
                picContact.Text = open.FileName;
                picContact.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void cbxFonction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}