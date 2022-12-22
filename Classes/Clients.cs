using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final
{
    // Attributs privés
    public class Clients
    {
        private string permis;
        private string nom;
        private string prenom;
        private string telephone;        

        // Accesseurs (propriétés)
        public string Permis
        {
            get { return permis; }
            set { permis = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }              

        // Constructeurs par défaut avec paramètre
        public Clients()
        {
            permis = "";
            nom = "";
            prenom = "";
            telephone = "";            
        }

        /// <summary>
        /// Constructeurs
        /// </summary>
        /// <param name="p_permis"></param>
        /// <param name="p_nom"></param>
        /// <param name="p_prenom"></param>
        /// <param name="p_telephone"></param>       
        public Clients(string p_permis, string p_nom, string p_prenom, string p_telephone)
        {
            this.permis = p_permis;
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.telephone = p_telephone;                      
        }

        // méthode qui un tableau contenant les différentes valeurs des attributs
        public virtual string[] ToArray()
        {
            string[] proprietes = new string[4];
            proprietes[0] = permis;
            proprietes[1] = nom;
            proprietes[2] = prenom;
            proprietes[3] = telephone;           
            return proprietes;
        }

    }
}
    

