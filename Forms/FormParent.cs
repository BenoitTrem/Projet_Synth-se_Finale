using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final
{
    public partial class FormParent : Form
    {
        // Form Parent qui s'affiche losqu'on exécute l'application pour la première fois
        public FormParent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {       
            FormClient formAjouter = new FormClient(); // Création d'une instance du formulaire enfant FormClient          
            formAjouter.WindowState = FormWindowState.Normal;
            formAjouter.Show(); // Affiche FormClient

        }

        private void button_employe_Click(object sender, EventArgs e)
        {          
            FormEmploye formAjouter = new FormEmploye();// Création d'une instance du formulaire enfant FormEmploye         
            formAjouter.WindowState = FormWindowState.Normal;
            formAjouter.Show(); // Affiche le FormEmploye    
        }

        private void FormParent_Load(object sender, EventArgs e)
        {

        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            this.Close(); // Boutton qui va fermer l'application
        }
    }
}
