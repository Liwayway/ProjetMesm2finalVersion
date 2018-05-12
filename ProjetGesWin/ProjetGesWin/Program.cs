using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGesWin
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {   // Au lancement de l'application, le nombre de clients est égal à zéro,
            // ainsi que le nombre de Contacts
            // au lancement de l'application, initialiser le nombre de stagiaires
            MClients.NClients = 0;
            MCommercial.NContacts = 0;

            /*
            //initialisation d'1 client pour l'avoir dès le début du programme pour les tests.
            // modifier le code pour pouvoir afficher la liste des clients dès le lancement du programme
            
            // si des données existent
            MClients nouveauClient = new MClients();
            nouveauClient.NumClient = 12;
            nouveauClient.RaisonSociale = "SARL Test";
            nouveauClient.AdresseClient = "23 ici";
            nouveauClient.AdresseClient2 = "Bat. Là";
            nouveauClient.CodePostal = "06660";
            nouveauClient.Ville = "Paris";
            nouveauClient.TelephoneClient = "0101010101";
            nouveauClient.ClientPrive = false;
            nouveauClient.Effectif = 12;
            nouveauClient.ChiffreAffaires = 234;
            Donnees.arrayClients.Add(nouveauClient);
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMDI());
        }
    }
}
