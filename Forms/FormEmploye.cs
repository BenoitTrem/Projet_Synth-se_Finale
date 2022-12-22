using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final
{
    public partial class FormEmploye : Form
    {
        public FormEmploye()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode qui initialise les label
        /// </summary>
        public void InitialiserLabel()
        {
            labelPermis.Text = labelNumero.Text = "";
        }
        /// <summary>
        ///  Méthode qui affiche les labels d'erreur losrqu'il y a des erreurs dans le formulaire
        /// </summary>
        /// <param name="modele"></param>
        /// <param name="tb"></param>
        /// <param name="lb"></param>
        /// <param name="messageErreur"></param>
        /// <returns></returns>
        public bool VerifierRegex(string modele, TextBox tb, Label lb, string messageErreur)
        {
            //Créer du Regex reg 
            Regex reg = new Regex(modele);
            //Vérifier la correspondance entre le champ entré dans la textBox et le modèle
            if (!reg.IsMatch(tb.Text))
            {
                //Afficher le message d'erreur
                lb.ForeColor = Color.Red;
                lb.Text = messageErreur;
                //Effacer la TextBox 
                tb.Clear();
                return false;
            }
            else lb.Text = "";
            return true;
        }
        /// <summary>
        /// Méthode qui valide tous les données qui vont être entrés par le client
        /// </summary>
        /// <returns></returns>
        public bool VerifierTous()
        {
            bool b_numero, b_permis;
            b_numero = VerifierRegex("^[0-9]{5}$", textBox_Numero, labelNumero, "5 chiffres");
            b_permis = VerifierRegex("^[A-Z]{1}[0-9]{12}$", textBox_Permis, labelPermis, "Première letrre de votre nom + 4 chiffre + date de naissance + 2 chiffres");         
            if (b_permis)
                return true;
            else return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {                        
        }

        /// <summary>
        /// Méthode qui initialise les textBox
        /// </summary>
        public void InitialiserControles()
        {
            //Réinitialiser tous les champs du formulaire         
            textBox_Permis.Text = "";
            textBox_Permis.Text = "";
        }
        public void AfficherClients(Clients c)
        {           
            //Initialiser tous les autres champs du formulaire aux attributs
            textBox_Permis.Text = c.Permis.ToString();
           
        }
        /// <summary>
        /// Affcihe le FormClient lorsqu'on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cLientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient formAjouter = new FormClient();//Création d'une instance du formulaire enfant FormSupprimerEtudiant         
            formAjouter.WindowState = FormWindowState.Normal;
            formAjouter.Show();
            this.Close();
        }
        /// <summary>
        /// Ferme le FormEmploye
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Méthode qui affiche la listView
        /// </summary>
        /// <param name="v"></param>
        public void AfficherClientListview(Vehicule v)
        {
            string[] arr = new string[9];
            ListViewItem itm;
            //Préparer les items dans un tableau
            arr[0] = v.Permis;
            arr[1] = v.Nom;
            arr[2] = v.Prenom;
            arr[3] = v.Telephone;
            arr[4] = v.Modele;
            arr[5] = v.Prix.ToString();
            arr[6] = v.Immatriculation;
            arr[7] = v.Jour.ToString();
            arr[8] = v.Date.ToShortDateString().ToString();
            //Créer un ListViewItem
            itm = new ListViewItem(arr);
            //Ajouter la l'item ListViewItem à la listView1
            listView1.Items.Add(itm);
        }
        /// <summary>
        /// Bouton Rechercher, recherche dans la liste statique un client selon le permis entré et affiche le
        /// client dans la listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Rechercher_Click_1(object sender, EventArgs e)
        {
            InitialiserLabel();
            listView1.Items.Clear(); // Rénétilise la listView
            bool trouve = false;         
            if (VerifierTous())
            {              
                foreach (Vehicule c in Statistique_Client.ListClients)
                {
                    if (c.Permis == textBox_Permis.Text) // Si le permis entré est dans la liste il affiche le client dans la listView
                    {
                        AfficherClientListview(c); // Affiche la listView
                        trouve = true;
                    }                  
                }
                if (trouve == false)// Si le client inscrits n'est pas dans la liste statique
                    MessageBox.Show("Il n'y à pas de véhicule loué à ce permis");
            }
        }
    }
}
