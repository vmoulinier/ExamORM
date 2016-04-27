namespace ExamORM
{
    partial class Form2
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
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.comboBoxMatiere = new System.Windows.Forms.ComboBox();
            this.comboBoxDevoir = new System.Windows.Forms.ComboBox();
            this.listBoxEleve = new System.Windows.Forms.ListBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.labelClasse = new System.Windows.Forms.Label();
            this.labelMatiere = new System.Windows.Forms.Label();
            this.labelDevoir = new System.Windows.Forms.Label();
            this.labelEleve = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(94, 33);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClasse.TabIndex = 0;
            this.comboBoxClasse.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasse_SelectedIndexChanged);
            // 
            // comboBoxMatiere
            // 
            this.comboBoxMatiere.FormattingEnabled = true;
            this.comboBoxMatiere.Location = new System.Drawing.Point(408, 33);
            this.comboBoxMatiere.Name = "comboBoxMatiere";
            this.comboBoxMatiere.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMatiere.TabIndex = 1;
            this.comboBoxMatiere.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatiere_SelectedIndexChanged);
            // 
            // comboBoxDevoir
            // 
            this.comboBoxDevoir.FormattingEnabled = true;
            this.comboBoxDevoir.Location = new System.Drawing.Point(94, 92);
            this.comboBoxDevoir.Name = "comboBoxDevoir";
            this.comboBoxDevoir.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDevoir.TabIndex = 2;
            this.comboBoxDevoir.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevoir_SelectedIndexChanged);
            // 
            // listBoxEleve
            // 
            this.listBoxEleve.FormattingEnabled = true;
            this.listBoxEleve.ItemHeight = 16;
            this.listBoxEleve.Location = new System.Drawing.Point(94, 143);
            this.listBoxEleve.Name = "listBoxEleve";
            this.listBoxEleve.Size = new System.Drawing.Size(199, 100);
            this.listBoxEleve.TabIndex = 3;
            this.listBoxEleve.SelectedIndexChanged += new System.EventHandler(this.listBoxEleve_SelectedIndexChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(408, 142);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(121, 22);
            this.textBoxNom.TabIndex = 4;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(408, 180);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(121, 22);
            this.textBoxPrenom.TabIndex = 5;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(408, 219);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(121, 22);
            this.textBoxNote.TabIndex = 6;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(408, 278);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(121, 23);
            this.buttonEnregistrer.TabIndex = 7;
            this.buttonEnregistrer.Text = "Enregister";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Location = new System.Drawing.Point(24, 40);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(50, 17);
            this.labelClasse.TabIndex = 8;
            this.labelClasse.Text = "Classe";
            // 
            // labelMatiere
            // 
            this.labelMatiere.AutoSize = true;
            this.labelMatiere.Location = new System.Drawing.Point(334, 33);
            this.labelMatiere.Name = "labelMatiere";
            this.labelMatiere.Size = new System.Drawing.Size(55, 17);
            this.labelMatiere.TabIndex = 9;
            this.labelMatiere.Text = "Matiere";
            // 
            // labelDevoir
            // 
            this.labelDevoir.AutoSize = true;
            this.labelDevoir.Location = new System.Drawing.Point(24, 99);
            this.labelDevoir.Name = "labelDevoir";
            this.labelDevoir.Size = new System.Drawing.Size(49, 17);
            this.labelDevoir.TabIndex = 10;
            this.labelDevoir.Text = "Devoir";
            // 
            // labelEleve
            // 
            this.labelEleve.AutoSize = true;
            this.labelEleve.Location = new System.Drawing.Point(24, 180);
            this.labelEleve.Name = "labelEleve";
            this.labelEleve.Size = new System.Drawing.Size(43, 17);
            this.labelEleve.TabIndex = 11;
            this.labelEleve.Text = "Eleve";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(334, 147);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 12;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(334, 183);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(57, 17);
            this.labelPrenom.TabIndex = 13;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(334, 224);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(38, 17);
            this.labelNote.TabIndex = 14;
            this.labelNote.Text = "Note";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 355);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelEleve);
            this.Controls.Add(this.labelDevoir);
            this.Controls.Add(this.labelMatiere);
            this.Controls.Add(this.labelClasse);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.listBoxEleve);
            this.Controls.Add(this.comboBoxDevoir);
            this.Controls.Add(this.comboBoxMatiere);
            this.Controls.Add(this.comboBoxClasse);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.ComboBox comboBoxMatiere;
        private System.Windows.Forms.ComboBox comboBoxDevoir;
        private System.Windows.Forms.ListBox listBoxEleve;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label labelClasse;
        private System.Windows.Forms.Label labelMatiere;
        private System.Windows.Forms.Label labelDevoir;
        private System.Windows.Forms.Label labelEleve;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNote;
    }
}