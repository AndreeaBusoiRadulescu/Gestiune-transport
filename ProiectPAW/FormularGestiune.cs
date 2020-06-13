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
    public partial class FormularGestiune : Form
    {
        public FormularGestiune()
        {
            InitializeComponent();
        }

        private void Formular_gestiune_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdaugaSofer_Click(object sender, EventArgs e)
        {
            FormularSofer Fsofer = new FormularSofer();
            Fsofer.Show();
            this.Hide();
        }

        private void btnAdaugaTransport_Click(object sender, EventArgs e)
        {
            FormularTransport Ftransport = new FormularTransport();
            Ftransport.Show();
            this.Hide();
        }

        private void btnAdaugaMasina_Click(object sender, EventArgs e)
        {
            FormularMasina Fmasina = new FormularMasina();
            Fmasina.Show();
            this.Hide();
        }

        private void btnListaCurse_Click(object sender, EventArgs e)
        {
            FormularLista Flista = new FormularLista();
            Flista.Show();
            this.Hide();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Busoi-Radulescu Andreea");
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
