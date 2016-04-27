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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            comboBoxDevoir.Enabled = false;
            listBoxEleve.Enabled = false;
            textBoxNom.Enabled = false;
            textBoxNote.Enabled = false;
            textBoxPrenom.Enabled = false;
            buttonEnregistrer.Enabled = false;

            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            var lesClasses = (from c in dc.classe
                              select c).ToList();

            foreach (var n in lesClasses)
                comboBoxClasse.Items.Add(n);            
        }

        private void listBoxEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            eleve EleveSelectionne = listBoxEleve.SelectedItem as eleve;

            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            if (EleveSelectionne != null)
            {
                textBoxNom.Text = EleveSelectionne.nom;
                textBoxPrenom.Text = EleveSelectionne.prenom;
                comboBoxDevoir.Enabled = true;
                buttonEnregistrer.Enabled = true;
                textBoxNote.Enabled = true;
                textBoxNote.Text = " ";
            }
        }

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe laClasse = comboBoxClasse.SelectedItem as classe;
            
            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            var lesMatieres = (from c in dc.matiere
                               select c).ToList();

            textBoxNote.Enabled = false;
            if (laClasse != null)
            {
                listBoxEleve.Items.Clear();
                comboBoxMatiere.Items.Clear();
                textBoxNom.Text = " ";
                textBoxPrenom.Text = " ";
                textBoxNote.Text = " ";

                if (laClasse.eleve.Count == 0)
                {
                    MessageBox.Show("Pas d'élèves dans cette classe !");
                }
                else
                {
                    comboBoxDevoir.Enabled = false;

                    foreach (var c in laClasse.eleve)
                        listBoxEleve.Items.Add(c);

                    foreach (var n in lesMatieres)
                            comboBoxMatiere.Items.Add(n);
                }
            }
        }

        private void comboBoxMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            matiere lesMatieres = comboBoxMatiere.SelectedItem as matiere;

            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            var lesDevoirs = (from b in dc.devoir
                              where b.id_matiere == lesMatieres.id_matiere
                              select b).ToList();

            listBoxEleve.Enabled = true;
            comboBoxDevoir.Items.Clear();
            if (lesDevoirs != null)
            {
                foreach (var n in lesDevoirs)
                    comboBoxDevoir.Items.Add(n);
            }

        }

        private void comboBoxDevoir_SelectedIndexChanged(object sender, EventArgs e)
        {
            eleve EleveSelectionne = listBoxEleve.SelectedItem as eleve;
            devoir lesDevoirs = comboBoxDevoir.SelectedItem as devoir;
            

            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            var laNote = (from b in dc.noter
                          where b.id_devoir == lesDevoirs.id_devoir && b.id_eleve == EleveSelectionne.id_eleve
                          select b).ToList();

            textBoxNote.Text = " ";
            if (laNote != null)
            {
                foreach (var n in laNote)
                    textBoxNote.Text = n.note.ToString();
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            DataContextGestionNotesDataContext dc = new DataContextGestionNotesDataContext();

            noter laNote = comboBoxDevoir.SelectedItem as noter;

            if (laNote != null)
            {
                //laNote.note = textBoxNote.Text; //impossible de convertire string en double
            }

            dc.SubmitChanges();
        }
    }
}
