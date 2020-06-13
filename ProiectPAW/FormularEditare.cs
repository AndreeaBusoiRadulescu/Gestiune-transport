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
    public partial class FormularEditare : Form
    {
        Transport instance;

        public FormularEditare(Transport transport)
        {
            InitializeComponent();
            instance = transport;
        }

        private void btnFormularGestiune_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalveza_Click(object sender, EventArgs e)
        {
            Masina masina = null;
            Sofer sofer = null;
            if (lvMasina.SelectedItems.Count != 0)
            {
                List<Masina> masini = new TransportContext().Masini.ToList();
                masina = masini.ElementAt(lvMasina.SelectedIndices[0]);
            }
            instance.Masina = masina;

            if (lvSofer.SelectedItems.Count != 0)
            {
                List<Sofer> soferi = new TransportContext().Soferi.ToList();
                sofer = soferi.ElementAt(lvSofer.SelectedIndices[0]);
            }
            instance.Sofer = sofer;

            instance.DenumireIncarcatura = tbDenumire.Text;
            if (String.Equals(cbOras.Text, "BUCURESTI"))
            {
                instance.Oras = Oras.BUCURESTI;
            }
            else if (String.Equals(cbOras.Text, "CONSTANTA"))
            {
                instance.Oras = Oras.CONSTANTA;
            }
            else if (String.Equals(cbOras.Text, "PITESTI"))
            {
                instance.Oras = Oras.PITESTI;
            }
            else if (String.Equals(cbOras.Text, "PLOIESTI"))
            {
                instance.Oras = Oras.PLOIESTI;
            }
            else if (String.Equals(cbOras.Text, "TARGOVISTE"))
            {
                instance.Oras = Oras.TARGOVISTE;
            }
            else if (String.Equals(cbOras.Text, "VALCEA"))
            {
                instance.Oras = Oras.VALCEA;
            }
            
            this.Hide();
            
        }

        private void FormularEditare_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = instance.DenumireIncarcatura;
            cbOras.Text = instance.Oras.ToString();
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

            //Ia masini din baza de date
            List<Masina> masini = new TransportContext().Masini.ToList();

            foreach (Masina m in masini)
            {
                string[] row = { m.Id.ToString(), m.Denumire, m.NumarMasina};
                ListViewItem item = new ListViewItem(row);
                lvMasina.Items.Add(item);
            }
        }
    }
}
