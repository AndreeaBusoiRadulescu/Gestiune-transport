using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ProiectPAW
{
    public partial class FormularLista : Form
    {
        //Context al maparii cu baza de date
        //Cu ajutorul ei putem folosi functiile CRUD pe entitati
        TransportContext DbCtx;

        public FormularLista()
        {
            DbCtx = new TransportContext();
            InitializeComponent();
        }

        private void btnGestionare_Click(object sender, EventArgs e)
        {
            FormularGestiune gestiune = new FormularGestiune();
            gestiune.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DespreBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Busoi-Radulescu Andreea");
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                List<Transport> lista = DbCtx.Transporturi.Include(b => b.Masina)
                            .Include(b => b.Sofer)
                            .ToList();
                foreach (Transport each in lista)
                {
                    sw.Write(each.Masina.Denumire + " " + each.Masina.NumarMasina + " " + each.Sofer.NumeSofer + " " + each.Sofer.DataAngajare + " " + each.DenumireIncarcatura + " " + each.Oras.ToString() + "\n");
                }
                sw.Close();
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Transport>));

            FileStream fs = File.Create("lista.xml");
            List<Transport> lista = DbCtx.Transporturi.Include(b => b.Masina)
                                .Include(b => b.Sofer)
                                .ToList();
            xmlSerializer.Serialize(fs, lista);

            fs.Close();
            MessageBox.Show("Serializare cu succes in lista.xml");
        }

        private void importXML(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Transport>));

            try
            {
                FileStream fs = File.OpenRead(filename);
                List<Transport> lista = xmlSerializer.Deserialize(fs) as List<Transport>;

                foreach (Transport transport in lista)
                {
                    //if(!DbCtx.Transporturi.Any(o => o.Id == transport.Id))
                    Transport transport2 = new Transport();

                    transport2 = transport;
                    transport2.Masina.Id = 0;
                    transport2.Sofer.Id = 0;
                    transport2.Id = 0;

                    DbCtx.Transporturi.Add(transport2);
                }
                DbCtx.SaveChanges();
                fs.Close();

            }
            catch (Exception ex)
            {
                throw new CustomExceptionXML();
            }

            dataGridView.DataSource = DbCtx.Transporturi.ToList();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importXML("lista.xml");
        }


        private void FormularLista_Load(object sender, EventArgs e)
        {
            //Mapeaza/Asociaza dataGrid0ului elementele din baza de date
            List<Transport> lista = DbCtx.Transporturi.Include(b => b.Masina)
                                .Include(b => b.Sofer)
                                .ToList();

            dataGridView.DataSource = lista;
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                Transport transport = DbCtx.Transporturi.ToList()[dataGridView.SelectedRows[0].Index];
                // Transport transport = DbCtx.Transporturi.Find(dataGridView.SelectedRows[0].Index + 1);
                FormularEditare editare = new FormularEditare(transport);
                editare.ShowDialog();

                DbCtx.Transporturi.Update(transport);
                DbCtx.SaveChanges();
                //populare gridView
                dataGridView.DataSource = DbCtx.Transporturi.ToList();
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi acest transport?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Transport transport = DbCtx.Transporturi.ToList()[dataGridView.SelectedRows[0].Index];

                    DbCtx.Transporturi.Remove(transport);
                    //DbCtx.Transporturi.Remove(transportBindingSource3.Current as Transport);
                    DbCtx.SaveChanges();

                    dataGridView.DataSource = DbCtx.Transporturi.ToList();
                }
            }
        }

        //Scurtatura print
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                pageSetupDialog.Document = printDocument;
                pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

                if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Brush brush = Brushes.DarkOrange;
            Font font = new Font("Consolas", 20);

            Pen pen = new Pen(brush);

            PageSettings settings = printDocument.DefaultPageSettings;
            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Bottom - settings.Margins.Top;

            if (settings.Landscape)
            {
                var temp = totalDrawableH;
                totalDrawableH = totalDrawableW;
                totalDrawableW = temp;
            }

            int cellWidth = totalDrawableW / 2;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawString("Lista transporturi - ", font, brush, totalDrawableW / 3, y);

            y += 100;

            // desenare cap tabel
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);

            // desensare denumire coloane
            graphics.DrawString("Denumire incarcatura", font, brush, x, y);
            graphics.DrawString("ID", font, brush, x + cellWidth, y);

            y += cellHeight;

            foreach (Transport t in DbCtx.Transporturi.ToList())
            {
                // desenare tabel
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);

                // desensare continut
                graphics.DrawString(t.DenumireIncarcatura, font, brush, x, y);
                graphics.DrawString(t.Id.ToString(), font, brush, x + cellWidth, y);

                y += cellHeight;
            }
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {

        }

        private void OnDropXML(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            try
            {
                importXML(fileList[0]);
            }
            catch(CustomExceptionXML ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnDragXML(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
