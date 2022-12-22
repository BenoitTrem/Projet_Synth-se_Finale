using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final.Forms
{
    // Classe abstraite
    abstract class Employe
    {
        // Attributs privés
        private int numero;

        // Accesseurs (propriétés)
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        // Constructeurs par défaut et avec paramètres
        public Employe()
        {
            numero = 0;
            
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="p_numero"></param>
        public Employe(int p_numero)
        {

            this.numero = p_numero;           
        }
    }
}
