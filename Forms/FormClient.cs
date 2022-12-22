using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;
using Projet_Synthèse_Final;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final
{
    public partial class FormClient : Form
    {
        // Form qu le client doit remplir pour louer un véhicule
       
        public FormClient()
        {
            InitializeComponent();
            
        }
        
        /// <summary>
        /// Méthode qui permet d'initialiser les label dans le formulaire
        /// </summary>
        public void InitialiserLabel()
        {
            labelPermis.Text = labelNom.Text = labelPrenom.Text = labelTelephone.Text = labelVehicule.Text = labelJour.Text = 
                labelSupprimer.Text = labelModifie.Text = "";
        }
        /// <summary>
        /// Méthode qui affiche les labels d'erreur losrqu'il y a des erreurs dans le formulaire
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
        /// Méthode qui affiche un label d'erreur lorqu'il y a une erreur avec la ComboBox dans le formulaire
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="lb"></param>
        /// <returns></returns>
        public bool VerifierCombobox(ComboBox cb, Label lb)
        {
            // Si l'utilisateur a choisi une valeur de la liste
            if (cb.Text != "") { lb.Text = ""; return true; }
            else //Sinon afficher un message d'erreur
            {
                lb.ForeColor = Color.Red; lb.Text = " Erreur / Entrez une données valide"; return false;
            }

        }
        /// <summary>
        /// Méthode qui valide tous les données qui vont être entrés par le client
        /// </summary>
        /// <returns>retrun true quand tous est valide sinon affiche les labels d'erreurs</returns>
        public bool VerifierTous()
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_permis, b_nom, b_prenom, b_telephone, b_combo_vehicule, b_jour;
            //Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_permis = VerifierRegex("^[A-Z]{1}[0-9]{12}$", textBox_Permis, labelPermis, "Première letrre de votre nom + 4 chiffre + date de naissance + 2 chiffres");
            b_nom = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", textBox_Nom, labelNom, "Lettre majuscule suivie de 1 à 10 lettres minuscules");
            b_prenom = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", textBox_Prenom, labelPrenom, "Lettre majuscule suivie de 1 à 20 lettres minuscules");
            b_telephone = VerifierRegex("^[0-9]{10}$", textBox_Telephone, labelTelephone, "Code régionale suivi de votre numéro numéro sans espace EX: 8191234567");
            // Vérifier que la combobox contient une valeur
            b_combo_vehicule = VerifierCombobox(comboBox_Modele, labelVehicule);
            b_jour = VerifierRegex("^[1-5]{1}$",textBox_Jour, labelJour,"Veuillez choisir un nombre de jours (5 max)");
            //Vérifier que l'une des deux radioButton est cochée          
            // Si toutes les vérifications sont valides retourner vrai
            if (b_permis && b_nom && b_prenom && b_telephone && b_combo_vehicule && b_jour)
                return true;
            else return false; //Sinon retourner faux
        }
       
        private void FormClient_Load(object sender, EventArgs e)
        {                                
        }

        /// <summary>
        /// Méthode qui affiche les informations du client dans le listView
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
        /// Bouton qui ajoute un client dans la liste et qui affiche les informations dans la listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            InitialiserLabel();
            if (VerifierTous()) // Si tous les champs entrés sont valides           
            {                              
                //Instancier un electeur avec les champs entrés par l'utilisateur
                Vehicule cli = new Vehicule(textBox_Permis.Text, textBox_Nom.Text, textBox_Prenom.Text, textBox_Telephone.Text,
                    comboBox_Modele.Text, int.Parse(textBox_Prix.Text),textBox_Matricule.Text, int.Parse(textBox_Jour.Text), dateTimePicker1.Value.Date);               
                // Ajouter cet électeur au disctionnaire de la classe statique Clients
                
                if (!Statistique_Client.ListClients.Contains(cli)) // Si le même client n'est pas dans la liste
                {
                    Statistique_Client.ListClients.Add(cli);
                    foreach (Vehicule c in Statistique_Client.ListClients) // Pour chaque valeur dans la liste statique
                    {
                        if (c.Permis == textBox_Permis.Text)
                        {
                            AfficherClientListview(c); // Ajout des informations de la liste dans la listView
                        }
                        MessageBox.Show("Un véhicule à été ajouter à votre panier");
                        InitialiserControles();
                    }
                }
                else MessageBox.Show("Client existe déjà"); // Sinon affiche message d'erreur

            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs sans erreur"); // Sinon affiche un message d'erreur
            }
        }

        /// <summary>
        /// Méthode qui initialise les textBox et comboBox 
        /// </summary>
        public void InitialiserControles()
        {
            //Réinitialiser tous les champs du formulaire         
            textBox_Permis.Text = "";
            textBox_Nom.Text = "";
            textBox_Prenom.Text = "";
            textBox_Telephone.Text = "";
            textBox_Jour.Text = "";
            comboBox_Modele.SelectedIndex = -1;
            textBox_Prix.Text = "";
            textBox_Matricule.Text = "";

        }   
        /// <summary>
        /// Affcihe le FormEmploye lorsqu'on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmploye formAjouter = new FormEmploye();//Création d'une instance du formulaire enfant FormSupprimerEtudiant           
            formAjouter.WindowState = FormWindowState.Normal;
            formAjouter.Show();
            
        }
        /// <summary>
        /// Ferme le FormClient lorsqu'on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   

        private void comboBox_Jour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Affiche le montant de la location pour une journée pour les différent index choisis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Modele_SelectedIndexChanged(object sender, EventArgs e)
        {         
            if (comboBox_Modele.SelectedIndex == 0) // si index 0 est choisi, le prix est de 5
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "5"; // Affiche 5 dans le textBox automatiquement
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "I74 D8E";
            }
            if (comboBox_Modele.SelectedIndex == 1)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "6";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "T45 K9A";
            }
            if (comboBox_Modele.SelectedIndex == 2)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "8";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "L9I S4F";
            }
            if (comboBox_Modele.SelectedIndex == 3)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "7";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "5T9 FD5";
            }
            if (comboBox_Modele.SelectedIndex == 4)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "6";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "4D5 L90";
            }
            if (comboBox_Modele.SelectedIndex == 5)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "10";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "H3B KO9";
            }
            if (comboBox_Modele.SelectedIndex == 6)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "12";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "HA2 KU8";
            }
            if (comboBox_Modele.SelectedIndex == 7)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "10";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "JF9 56H";
            }
            if (comboBox_Modele.SelectedIndex == 8)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "11";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "X3C 0LP";
            }
            if (comboBox_Modele.SelectedIndex == 9)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "13";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "AL8 R41";
            }
            if (comboBox_Modele.SelectedIndex == 10)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "9";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "Y53 K9D";
            }
            if (comboBox_Modele.SelectedIndex == 11)
            {
                textBox_Prix.Text = "";
                textBox_Prix.Text = "14";
                textBox_Matricule.Text = "";
                textBox_Matricule.Text = "S81 JY8";
            }           
        }      

        /// <summary>
        /// Bouton supprimer, supprime le client de la liste et de la listView lorsque le client est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            InitialiserLabel();
            labelSupprimer.Text = "* Pour supprimer, sélectionner le permis *";
            
            foreach (ListViewItem Item in listView1.SelectedItems)
            {
                listView1.Items.Remove(Item); // Si sélectionné, supprime le client de la listView
                Statistique_Client.ListClients.Clear(); // Supprime le client de la liste statique
                MessageBox.Show("Un véhicule à été supprimé");
                InitialiserLabel();
            }
            InitialiserControles();

            
        }

        /// <summary>
        /// Bouton modifier, éfface le client sélectionné et remplace par les nouvelle informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            InitialiserLabel();
            labelModifie.Text = "* Sélectionner le permis que vous voulez modifier *";  
            if (VerifierTous()) // Si tous les champs entrés sont valides
            {
                foreach (ListViewItem Item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(Item);
                    Statistique_Client.ListClients.Clear();                    
                    InitialiserLabel();
                }
                //Instancier un electeur avec les champs entrés par l'utilisateur
                Vehicule cli = new Vehicule(textBox_Permis.Text, textBox_Nom.Text, textBox_Prenom.Text, textBox_Telephone.Text,
                   comboBox_Modele.Text, int.Parse(textBox_Prix.Text), textBox_Matricule.Text, int.Parse(textBox_Jour.Text), dateTimePicker1.Value.Date);
                // Ajouter cet électeur au disctionnaire de la classe statique Election
                Statistique_Client.ListClients.Add(cli);
                foreach (Vehicule c in Statistique_Client.ListClients)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { c.Permis.ToString(), c.Nom, c.Prenom, c.Telephone, c.Modele, c.Prix.ToString()
                        , c.Immatriculation, c.Jour.ToString(),c.Date.ToShortDateString()}));
                }
                MessageBox.Show("Un véhicule à été modifié");
                InitialiserControles();
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs sans erreur");
            }
        }

        /// <summary>
        /// Bouton sauvegarder, sauvegarde les informations dans le serveur sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Sauvegarder_Click(object sender, EventArgs e)
        {
            AdoNET Ado = new AdoNET();
            string Query = "Select * from Vehicule;";
            //Préparer l'objet Command en mettant dans la CommandText la chaîne Query préparée
            Ado.Command.CommandText = Query;
            //Mettre dans la propriété Connection de l’objet Command l’objet Connection qu’on a
            //préparé (instancié)
            Ado.Command.Connection = Ado.Connection;
            Ado.Adapter.SelectCommand = Ado.Command;
            //Ado.Adapter.Fill(Ado.DsLocation);

            //la table Vehicule est la première table (indice 0) du DataSet DsScolarite. Si au
            //lieu d’utiliser une requête SQL on utilise une procédure stockée qui
            // retourne plusieurs tables, ces tables seront dans le DataSet Ado.DsScolarite
            // et pour y accéder il suffit d’utiliser le bon indice : 0,1,2, etc. Dans notre
            //cas, la requête retourne une seule table. On met ce résultat dans la DataTable
            // DtVehicule

            //Ado.DtVehicule = Ado.DsLocation.Tables[0];

            //Afficher la table Ado.DtVehicule dans notre dataGridView : il suffi
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder
                // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter.
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.
                Ado.Adapter.Update(Ado.DsLocation, Ado.DtVehicule.ToString());                
            }
            catch (Exception)
            {
                MessageBox.Show("Sauvegarde des informations");
            }
        }
    }
}
