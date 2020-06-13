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
    public partial class FormularSofer : Form
    {
        public FormularSofer()
        {
            InitializeComponent();
        }

        private void FormularSofer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }

        private void btnFormularGestiune_Click(object sender, EventArgs e)
        {
            FormularGestiune FGestiune = new FormularGestiune();
            FGestiune.Show();
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

        private void tbNumeSofer_Validating(object sender, CancelEventArgs e)
        {
            String numeSofer = tbNumeSofer.Text;
            if(String.IsNullOrEmpty(numeSofer) || String.IsNullOrWhiteSpace(numeSofer))
            {
                epNumeSofer.SetError((Control)sender,"Completati numele soferului!");
                e.Cancel = true;
            }
        }

        private void tbNumeSofer_Validated(object sender, EventArgs e)
        {
            epNumeSofer.Clear();
        }

        private void dtpDataAngajarii_Validating(object sender, CancelEventArgs e)
        {
            DateTime dataAngajare = dtpDataAngajarii.Value;
            string dateInput = "Jan 1, 1960";
            DateTime parsedDate = DateTime.Parse(dateInput);

            if (DateTime.Compare(dataAngajare, DateTime.Today) >= 0 || DateTime.Compare(dataAngajare, parsedDate) < 0)
            {
                epDataAngajarii.SetError(dtpDataAngajarii, "Data pentru publicatie invalida!");
                e.Cancel = true;
            }
            
        }

        private void dtpDataAngajarii_Validated(object sender, EventArgs e)
        {
            epNumeSofer.Clear();
        }

        private void btnAdaugaSofer_Click(object sender, EventArgs e)
        {
            String numeSofer = tbNumeSofer.Text;
            DateTime dateTime = dtpDataAngajarii.Value.Date;

            //Context baza de date
            TransportContext DbCtx = new TransportContext();

            //Noua entitate sofer
            Sofer sofer = new Sofer(numeSofer, dateTime);

            //Persistam entitatea in baza de date
            DbCtx.Soferi.Add(sofer);
            DbCtx.SaveChanges();
            MessageBox.Show("Inserat!");
            FormularGestiune gestiune = new FormularGestiune();
            gestiune.Show();
            this.Hide();
        }
    }
}
