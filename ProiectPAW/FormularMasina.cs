using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class FormularMasina : Form
    { 
        public FormularMasina()
        {
            InitializeComponent();
        }

        private void btnFormularGestiune_Click(object sender, EventArgs e)
        {
            FormularGestiune FGestiune = new FormularGestiune();
            FGestiune.Show();
            this.Hide();
        }

        private void FormularMasina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Busoi-Radulescu Andreea");
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdaugaMasina_Click(object sender, EventArgs e)
        {
            // Adauga o noua entitate de tip Masina
            Masina masina = new Masina(tbDenumire.Text, tbNumarMasina.Text);
            //OLD: listaMasini.Add(masina);

            //Inserare in baza de date
            TransportContext DbCtx = new TransportContext();
            DbCtx.Masini.Add(masina);
            //Commit tranzactie
            DbCtx.SaveChanges();

            FormularGestiune gestiune = new FormularGestiune();
            gestiune.Show();
            this.Hide();
        }

        private void FormularMasina_Load(object sender, EventArgs e)
        {

        }
    }
}
