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
    public partial class FormularTransport : Form
    {
        public FormularTransport()
        {
            InitializeComponent();

            //Populare listView cu Masini
            Populate_lvMasina();

            //Populare listView cu Soferi
            Populate_lvSoferi();

        }

        private void Populate_lvSoferi()
        {
            lvSofer.View = View.Details;
            //Seteaza header-ul coloanelor
            lvSofer.Columns.Add("ID");
            lvSofer.Columns.Add("Nume Sofer");
            lvSofer.Columns.Add("Data Angajare");
            lvSofer.Columns.Add("Disponibil");

            //Ia masini din baza de date
            List<Sofer> soferi = new TransportContext().Soferi.ToList();

            foreach (Sofer s in soferi)
            {
                string[] row = { s.Id.ToString(), s.NumeSofer, s.DataAngajare.ToString()};
                ListViewItem item = new ListViewItem(row);
                lvSofer.Items.Add(item);
            }
        }

        private void Populate_lvMasina()
        {
            lvMasina.View = View.Details;
            //Seteaza header-ul coloanelor
            lvMasina.Columns.Add("ID");
            lvMasina.Columns.Add("Denumire");
            lvMasina.Columns.Add("Numar Masina");
            lvMasina.Columns.Add("Disponibil");

            //Ia masini din baza de date
            List<Masina> masini = new TransportContext().Masini.ToList();

            foreach (Masina m in masini)
            {
                string[] row = { m.Id.ToString(), m.Denumire, m.NumarMasina};
                ListViewItem item = new ListViewItem(row);
                lvMasina.Items.Add(item);
            }

        }

        private void FormularTransport_FormClosed(object sender, FormClosedEventArgs e)
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

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            epDenumireIncarcatura.Clear();
        }

        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            String denumire = tbDenumire.Text;
            if(String.IsNullOrEmpty(denumire) || String.IsNullOrWhiteSpace(denumire))
            {
                epDenumireIncarcatura.SetError((Control)sender, "Introduceti detalii despre incarcatura!");
                e.Cancel = true; 
            }
        }

        private void btnAdaugaTransport_Click(object sender, EventArgs e)
        {
            Masina masina = null;
            Sofer sofer = null;
            if (lvMasina.SelectedItems.Count != 0)
            {
                List<Masina> masini = new TransportContext().Masini.ToList();
                masina = masini.ElementAt(lvMasina.SelectedIndices[0]);
            }

            if (lvSofer.SelectedItems.Count != 0)
            {
                List<Sofer> soferi = new TransportContext().Soferi.ToList();
                sofer = soferi.ElementAt(lvSofer.SelectedIndices[0]);
            }

            String denumire = tbDenumire.Text;

            Transport transport = new Transport();
            transport.Sofer = sofer;
            if (masina == null || sofer == null || denumire == null)
            {
                MessageBox.Show("Selectati toate campurile!");
            }

            if (String.Equals(cbOras.Text, "BUCURESTI"))
            {
                transport.Oras = Oras.BUCURESTI;
            }
            else if (String.Equals(cbOras.Text, "CONSTANTA"))
            {
                transport.Oras = Oras.CONSTANTA;
            }
            else if (String.Equals(cbOras.Text, "PITESTI"))
            {
                transport.Oras = Oras.PITESTI;
            }
            else if (String.Equals(cbOras.Text, "PLOIESTI"))
            {
                transport.Oras = Oras.PLOIESTI;
            }
            else if (String.Equals(cbOras.Text, "TARGOVISTE"))
            {
                transport.Oras = Oras.TARGOVISTE;
            }
            else if (String.Equals(cbOras.Text, "VALCEA"))
            {
                transport.Oras = Oras.VALCEA;
            }
            transport.Masina = masina;
            transport.DenumireIncarcatura = denumire;

            TransportContext ctx = new TransportContext();
            ctx.Entry(transport.Masina).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.Entry(transport.Sofer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.Transporturi.Add(transport);
            ctx.SaveChanges();


            FormularGestiune gestiune = new FormularGestiune();
            gestiune.Show();
            this.Hide();
        }     
    }
}
