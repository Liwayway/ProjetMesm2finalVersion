using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // Pour utiliser l'Array List
using System.Drawing; // Pour utiliser les images


namespace ProjetGesWin
{
    /// <summary>
    /// Classe Générale regroupant les données 
    /// des Clients et des contacts commerciaux
    /// </summary>

    public class Donnees
    {

        ///<summary>
        ///collection d'objets MClients
        /// </summary>
        public static ArrayList arrayClients = new ArrayList();
        
        public ArrayList ArrayClients
        {
            get { return arrayClients; }
            set { arrayClients = value; }
        }

        ///<summary>
        ///collection d'objets MCommercial
        /// </summary>
        public static ArrayList arrayCommercial = new ArrayList();
        public ArrayList ArrayCommercial
        {
            get { return arrayCommercial; }
            set { arrayCommercial = value; }


        }


        public static object getClientById(int id)
        {
            return Donnees.arrayClients[id];
        }


        public static object getCommercialById(int id)
        {
            return Donnees.arrayCommercial[id];
        }

    }
}

