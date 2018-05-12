using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjetGesWin
{

    /// <summary>
    /// classe des clients :
    /// permet de mémoriser les informations concernant un client
    /// comporte des membres propriétés et attributs
    /// et le nombre de clients
    /// donnée partagée par toutes les instances (==> static)
    /// </summary>
    public class MClients
    {
        /// <summary>
        /// nombre de Clients de la classe
        /// (donnée partagée par toutes les instances)
        /// </summary>
        public static Int32 NClients;

        ///<summary>
        ///Rang du Client
        /// </summary>

        private Int32 iClient;

        public Int32 IClient
        {
            get { return iClient; }
            set { value = iClient; }

        }




        /// <summary>
        /// obtient le numéro du client
        /// </summary>
        private Int32 numClient;

        public Int32 NumClient
        {
            get { return numClient; }
            set { numClient = value; }
        }

        ///<summary>
        /// Raison Sociale du client,  mettre en Uppercase
        /// </summary>
        private String raisonSociale;

        public String RaisonSociale
        {
            get { return raisonSociale; }
            set { raisonSociale = value.Trim().ToUpper(); }
        }



        /// <summary >
        /// Adresse du client, numéro, "rue", format libre
        /// </summary>
        private String adresseClient;

        public String AdresseClient
        {
            get { return adresseClient; }
            set { adresseClient = value; }
        }

        /// <summary>
        /// /Adresse Client complément
        /// </summary>
        /// 
        private String adresseClient2;

        public String AdresseClient2
        {
            get { return adresseClient2; }
            set { adresseClient2 = value; }
        }

        private String codePostalClient;

        /// <summary>
        /// l'utilisateur devra retourner un code postal valide d'exactement
        /// 5 chiffres entiers : gestion Exceptions
        /// </summary>
        public String CodePostal
        {
            get { return codePostalClient; }
            set
            {
                // l'appelant doit fournir un code postal valide à 5 chiffres
                Int32 i;  // variable de boucle
                Boolean erreur = false; // indicateur d'erreur

                if (value.Length == 5)
                {
                    for (i = 0; i < value.Length; i++)
                    {
                        if (!(Char.IsDigit(value[i]))) // charabia ??
                        { erreur = true; }
                    }
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        System.Windows.Forms.MessageBox.Show(
                        value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres",
                        "Erreur Classe MClients", System.Windows.Forms.MessageBoxButtons.OK);


                    }
                    else
                    {
                        codePostalClient = value; // tout est ok on affecte la propriété
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                    "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins",
                    "ErreurClasse MClients",
                    System.Windows.Forms.MessageBoxButtons.OK);

                }

            }
        }


        /// <summary>
        /// Definition de la ville, en majuscules
        /// </summary>
        private String villeClient;

        public String Ville
        {
            get { return villeClient; }
            set { villeClient = value.Trim().ToUpper(); }   // met la ville en majuscules
        }

        /// <summary>
        /// Telephone du client, penser à mettre un controle sur le format
        /// </summary>
        private string telephoneClient;

        public string TelephoneClient
        {
            get { return telephoneClient; }
            set { telephoneClient = value; }
        }

        /// <summary>
        /// L'effectif de l'entreprise du client, 
        /// la saisie par le client est facultative
        /// Penser à faire un affichage "information non communiquée" si rien n'est saisi
        /// </summary>
        private int effectifClient;

        public int Effectif
        {
            get { return effectifClient; }
            set { effectifClient = value; }
        }


        /// <summary>
        /// Activité à choisir dans la liste déroulante
        /// </summary>
        private String activiteClient;

        public String Activite
        {
            get { return activiteClient; }
            set { activiteClient = value; }
        }

        /// <summary>
        /// La saisie par le client est facultative
        /// Penser à mettre "info non communiquée" si pas de saisie
        /// Penser à mettre un controle ou gérer une exception si mauvais format
        /// </summary>
        private float chiffreAffairesClient;

        public float ChiffreAffaires
        {
            get { return chiffreAffairesClient; }
            set { chiffreAffairesClient = value; }
        }

        /// <summary>
        /// Nature du client 
        /// </summary>
        private String natureClient;

        public String Nature
        {
            get { return natureClient; }
            set { natureClient = value; }
        }

        /// <summary>
        /// Type de Client (public/privé) privé quand la case est cochée, on va dire 
        /// privé = true = checkbox checked
        /// </summary>

        private Boolean clientPrive;

        public Boolean ClientPrive
        {
            get { return clientPrive; }
            set { clientPrive = value; }

        }
        
    }
}
