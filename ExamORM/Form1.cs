using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            var lesClasses = (from c in dc.classe
                           select c).ToList();

            foreach (var n in lesClasses)
                comboBoxClasses.Items.Add(n);

        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe laClasse = comboBoxClasses.SelectedItem as classe;

            if (laClasse != null)
            {
                listBoxClasses.Items.Clear();
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                if (laClasse.eleve.Count == 0)
                {
                    MessageBox.Show("Pas d'élèves dans cette classe !");
                }
                else
                {
                    foreach (var c in laClasse.eleve)
                        listBoxClasses.Items.Add(c);
                }
            }
        }

        private void listBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            eleve EleveSelectionne = listBoxClasses.SelectedItem as eleve;
            
            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();
            var lesNotes = (from n in dc.noter
                            select n).ToList();
           
            if (EleveSelectionne != null)
            {
                    textBox1.Text = EleveSelectionne.nom;
                    textBox2.Text = EleveSelectionne.prenom;
                    textBox3.Text = EleveSelectionne.mail;
                    textBox4.Text = EleveSelectionne.mdp;
                    textBox5.Text = lesNotes.Average(m => m.note).ToString();
            }

        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            eleve EleveSelectionne = listBoxClasses.SelectedItem as eleve;

            if (EleveSelectionne != null)
            {
                EleveSelectionne.nom = textBox1.Text;
                EleveSelectionne.prenom = textBox2.Text;
                EleveSelectionne.mail = textBox3.Text;
                EleveSelectionne.mdp = textBox4.Text;
            }
            dc.SubmitChanges();
        }

    }
}
