using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final
{
    public static class Statistique_Client
    {       
        // Liste des clients
        private static List<Clients> listClients;

        //Accesseurs (propriétés)
        public static List<Clients> ListClients
        {
            get { return listClients; }
            set { listClients = value; }
        }

        // Constructeur
        static Statistique_Client()
        {
            ListClients = new List<Clients>();
        }
        
    }
}
