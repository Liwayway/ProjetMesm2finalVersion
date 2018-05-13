using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ProjetGesWin
{
    class MCommercial
    {
        /// <summary>
        /// classe des commerciaux :
        /// permet de mémoriser les informations concernant un contact commercial
        /// comporte des membres propriétés et attributs
        /// donnée partagée par toutes les instances (==> static)
        /// </summary>

        ///<summary>
        ///Nombre de Contacts commerciaux
        /// </summary>
        
        public static Int32 NContacts;

        ///<summary>
        ///Rang du contact commercial
        /// </summary>
        /// 
        private Int32 iContact;

        public Int32 IContact
        {
            get { return iContact; }
            set { value = iContact; }
        }

        ///<summary>
        ///Nom du contact, Forcer en majuscules
        /// </summary>
        private String nomContact;

        public String NomContact
        {
            get { return nomContact; }
            set { nomContact = value.Trim().ToUpper(); }
        }

        ///<summary>
        ///Prénom, en minuscule
        /// </summary>

        private String prenomContact;

        public String PrenomContact
        {
            get
            {
                return prenomContact;
            }
            set
            {
                prenomContact = value.Trim().ToLower();
            }
        }


        /// <summary>
        /// Verifier le format du numéro de téléphone
        /// </summary>
        private String telephoneContact;

        public String TelephoneContact
        {
            get { return telephoneContact; }
            set
            {
                Int32 i; // variable de boucle
                Boolean erreur = false; // indicateur d'erreur

                if (value.Length == 10) // 10 caractères attendus : OK
                {
                    for (i = 0; i < value.Length; i++) // controle chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i]))) // charabia ??
                        { erreur = true; }
                    } // fin de boucle controle chiffres
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        System.Windows.Forms.MessageBox.Show(value.ToString() +
                        "\n"
                        + "n'est pas un numéro de téléphone valide : uniquement des chiffres",
                        "Erreur Classe MCommercial", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        telephoneContact = value.ToString() ; // tout est bon, on affecte la propriété
                    }

                }
                else // il n'y a pas 5 caractères
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                    "n'est pas un numéro de téléphone valide : 10 chiffres, pas plus, pas moins",
                        "ErreurClasse MContact", System.Windows.Forms.MessageBoxButtons.OK);


                }
            }
        }


        /// <summary>
        /// Ne pas oublier de vérifier l'adresse email 
        /// Utiliser une regex ? ou trouver comment utiliser isValidEmail
        /// </summary>
        private String emailContact;

        public String Email
        {
            get { return emailContact; }



            set { emailContact = value; }
         }

        /// <summary>
        /// Fonction du Commercial, pas de contrôle nécessaire à effectuer
        /// A choisir dans la liste déroulante
        /// 
        /// </summary>
        private String fonctionContact;

        public String Fonction
        {
            get { return fonctionContact; }
            set { fonctionContact = value; }
        }


        // Photo affichée dans Contact

        private Image photoContact;

        public Image PhotoContact
        {
            get { return photoContact; }
            set { photoContact = value; }
        }

        private Int32 numClient;
        public Int32 NumClient
        {
            get { return numClient; }
            set { numClient = value; }
        }
        
    }
}
