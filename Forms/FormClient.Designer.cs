namespace Projet_Synthèse_Final
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPermis = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Telephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Permis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Louer = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.button_Sauvegarder = new System.Windows.Forms.Button();
            this.locationDataSet = new Projet_Synthèse_Final.LocationDataSet();
            this.labelVehicule = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelJour = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new Projet_Synthèse_Final.LocationDataSetTableAdapters.VehiculeTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationDataSet1 = new Projet_Synthèse_Final.LocationDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_Modele = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Jour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Matricule = new System.Windows.Forms.TextBox();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.labelModifie = new System.Windows.Forms.Label();
            this.locationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(300, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(852, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employéeToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(108, 49);
            this.clienteToolStripMenuItem.Text = "Client(e)";
            // 
            // employéeToolStripMenuItem
            // 
            this.employéeToolStripMenuItem.Name = "employéeToolStripMenuItem";
            this.employéeToolStripMenuItem.Size = new System.Drawing.Size(194, 28);
            this.employéeToolStripMenuItem.Text = "Employé(e)";
            this.employéeToolStripMenuItem.Click += new System.EventHandler(this.employéeToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 49);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephone.Location = new System.Drawing.Point(44, 228);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(0, 13);
            this.labelTelephone.TabIndex = 66;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(157, 168);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(0, 13);
            this.labelPrenom.TabIndex = 65;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(157, 116);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(0, 13);
            this.labelNom.TabIndex = 64;
            // 
            // labelPermis
            // 
            this.labelPermis.AutoSize = true;
            this.labelPermis.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelPermis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermis.Location = new System.Drawing.Point(74, 61);
            this.labelPermis.Name = "labelPermis";
            this.labelPermis.Size = new System.Drawing.Size(0, 13);
            this.labelPermis.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // textBox_Telephone
            // 
            this.textBox_Telephone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Telephone.Location = new System.Drawing.Point(181, 208);
            this.textBox_Telephone.Name = "textBox_Telephone";
            this.textBox_Telephone.Size = new System.Drawing.Size(189, 20);
            this.textBox_Telephone.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Permis de conduire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Numéro de télephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Prénom";
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Prenom.Location = new System.Drawing.Point(181, 146);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.Size = new System.Drawing.Size(189, 20);
            this.textBox_Prenom.TabIndex = 54;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Nom.Location = new System.Drawing.Point(181, 89);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(189, 20);
            this.textBox_Nom.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nom";
            // 
            // textBox_Permis
            // 
            this.textBox_Permis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Permis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Permis.Location = new System.Drawing.Point(181, 36);
            this.textBox_Permis.Name = "textBox_Permis";
            this.textBox_Permis.Size = new System.Drawing.Size(189, 20);
            this.textBox_Permis.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.button_Louer);
            this.groupBox2.Controls.Add(this.button_Supprimer);
            this.groupBox2.Controls.Add(this.button_Modifier);
            this.groupBox2.Controls.Add(this.button_Sauvegarder);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(34, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 99);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // button_Louer
            // 
            this.button_Louer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Louer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Louer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Louer.Location = new System.Drawing.Point(51, 27);
            this.button_Louer.Name = "button_Louer";
            this.button_Louer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Louer.Size = new System.Drawing.Size(119, 44);
            this.button_Louer.TabIndex = 13;
            this.button_Louer.Text = "Louer";
            this.button_Louer.UseVisualStyleBackColor = false;
            this.button_Louer.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Supprimer.Location = new System.Drawing.Point(234, 27);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Supprimer.Size = new System.Drawing.Size(119, 44);
            this.button_Supprimer.TabIndex = 9;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Modifier
            // 
            this.button_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modifier.Location = new System.Drawing.Point(421, 27);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Modifier.Size = new System.Drawing.Size(119, 44);
            this.button_Modifier.TabIndex = 10;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Sauvegarder
            // 
            this.button_Sauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sauvegarder.Location = new System.Drawing.Point(603, 27);
            this.button_Sauvegarder.Name = "button_Sauvegarder";
            this.button_Sauvegarder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Sauvegarder.Size = new System.Drawing.Size(119, 44);
            this.button_Sauvegarder.TabIndex = 11;
            this.button_Sauvegarder.Text = "Sauvegarder";
            this.button_Sauvegarder.UseVisualStyleBackColor = true;
            this.button_Sauvegarder.Click += new System.EventHandler(this.button_Sauvegarder_Click);
            // 
            // locationDataSet
            // 
            this.locationDataSet.DataSetName = "LocationDataSet";
            this.locationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelVehicule
            // 
            this.labelVehicule.AutoSize = true;
            this.labelVehicule.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicule.Location = new System.Drawing.Point(87, 57);
            this.labelVehicule.Name = "labelVehicule";
            this.labelVehicule.Size = new System.Drawing.Size(0, 13);
            this.labelVehicule.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Nombre de jour ";
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(135, 187);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(0, 13);
            this.labelJour.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 78;
            this.label9.Text = "Votre Panier";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(34, 510);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(794, 271);
            this.listView1.TabIndex = 81;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Permis";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prénom";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Téléphone";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Modele";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prix/journée";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Matricule";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nbr jour(s)";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date";
            this.columnHeader9.Width = 83;
            // 
            // locationDataSet1
            // 
            this.locationDataSet1.DataSetName = "LocationDataSet";
            this.locationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(179, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 87;
            this.label10.Text = "$ pour une journée";
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prix.Location = new System.Drawing.Point(138, 75);
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(35, 22);
            this.textBox_Prix.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 85;
            this.label11.Text = "Prix";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 84;
            this.label12.Text = "Modèle";
            // 
            // comboBox_Modele
            // 
            this.comboBox_Modele.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_Modele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Modele.FormattingEnabled = true;
            this.comboBox_Modele.Items.AddRange(new object[] {
            "Toyota Prius   (voiture)",
            "Honda Civic   (voiture)",
            "Chevrolet Trax   (voiture)",
            "Toyota Corolla   (voiture)",
            "Volkswagen Golf   (voiture)",
            "Ford Mustang   (voiture)",
            "Ford Série F   (camion)",
            "Ram 1500   (camion)",
            "Toyota RAV4   (camion)",
            "GMC Sierra   (camion)",
            "Chevrolet Silverado   (camion)",
            "Hoanda CR-V   (camion)"});
            this.comboBox_Modele.Location = new System.Drawing.Point(90, 33);
            this.comboBox_Modele.Name = "comboBox_Modele";
            this.comboBox_Modele.Size = new System.Drawing.Size(189, 23);
            this.comboBox_Modele.TabIndex = 83;
            this.comboBox_Modele.SelectedIndexChanged += new System.EventHandler(this.comboBox_Modele_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.textBox_Jour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Matricule);
            this.groupBox1.Controls.Add(this.comboBox_Modele);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labelJour);
            this.groupBox1.Controls.Add(this.labelVehicule);
            this.groupBox1.Controls.Add(this.textBox_Prix);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(455, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 263);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Véhicule";
            // 
            // textBox_Jour
            // 
            this.textBox_Jour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Jour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Jour.Location = new System.Drawing.Point(138, 163);
            this.textBox_Jour.Name = "textBox_Jour";
            this.textBox_Jour.Size = new System.Drawing.Size(35, 22);
            this.textBox_Jour.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Immatriculation";
            // 
            // textBox_Matricule
            // 
            this.textBox_Matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Matricule.Location = new System.Drawing.Point(138, 116);
            this.textBox_Matricule.Name = "textBox_Matricule";
            this.textBox_Matricule.Size = new System.Drawing.Size(152, 22);
            this.textBox_Matricule.TabIndex = 88;
            // 
            // labelSupprimer
            // 
            this.labelSupprimer.AutoSize = true;
            this.labelSupprimer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupprimer.Location = new System.Drawing.Point(292, 489);
            this.labelSupprimer.Name = "labelSupprimer";
            this.labelSupprimer.Size = new System.Drawing.Size(0, 16);
            this.labelSupprimer.TabIndex = 90;
            // 
            // labelModifie
            // 
            this.labelModifie.AutoSize = true;
            this.labelModifie.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelModifie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifie.Location = new System.Drawing.Point(292, 489);
            this.labelModifie.Name = "labelModifie";
            this.labelModifie.Size = new System.Drawing.Size(0, 16);
            this.labelModifie.TabIndex = 91;
            // 
            // locationDataSetBindingSource
            // 
            this.locationDataSetBindingSource.DataSource = this.locationDataSet;
            this.locationDataSetBindingSource.Position = 0;
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataMember = "Vehicule";
            this.vehiculeBindingSource.DataSource = this.locationDataSetBindingSource;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_Permis);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_Nom);
            this.groupBox3.Controls.Add(this.textBox_Prenom);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labelTelephone);
            this.groupBox3.Controls.Add(this.textBox_Telephone);
            this.groupBox3.Controls.Add(this.labelPrenom);
            this.groupBox3.Controls.Add(this.labelPermis);
            this.groupBox3.Controls.Add(this.labelNom);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(34, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 263);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 808);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelModifie);
            this.Controls.Add(this.labelSupprimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employéeToolStripMenuItem;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPermis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_Telephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Permis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Louer;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.Button button_Sauvegarder;
        private LocationDataSet locationDataSet;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label labelVehicule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.Label label9;
        private LocationDataSetTableAdapters.VehiculeTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private LocationDataSet locationDataSet1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Prix;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_Modele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.Label labelModifie;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private System.Windows.Forms.BindingSource locationDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Matricule;
        private System.Windows.Forms.TextBox textBox_Jour;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}