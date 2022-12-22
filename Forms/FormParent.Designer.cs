namespace Projet_Synthèse_Final
{
    partial class FormParent
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
            this.button_client = new System.Windows.Forms.Button();
            this.button_employe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_client
            // 
            this.button_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_client.Location = new System.Drawing.Point(57, 145);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(214, 74);
            this.button_client.TabIndex = 0;
            this.button_client.Text = "Client(e)";
            this.button_client.UseVisualStyleBackColor = true;
            this.button_client.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_employe
            // 
            this.button_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employe.Location = new System.Drawing.Point(57, 272);
            this.button_employe.Name = "button_employe";
            this.button_employe.Size = new System.Drawing.Size(214, 74);
            this.button_employe.TabIndex = 1;
            this.button_employe.Text = "Employé(e)";
            this.button_employe.UseVisualStyleBackColor = true;
            this.button_employe.Click += new System.EventHandler(this.button_employe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = " Location de \r\n    véhicule\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Quitter
            // 
            this.button_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quitter.Location = new System.Drawing.Point(93, 390);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(132, 74);
            this.button_Quitter.TabIndex = 3;
            this.button_Quitter.Text = "Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(329, 500);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_employe);
            this.Controls.Add(this.button_client);
            this.Name = "FormParent";
            this.Load += new System.EventHandler(this.FormParent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_employe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Quitter;
    }
}