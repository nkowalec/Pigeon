using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pigeon.Forms;
using System.IO;

namespace Pigeon
{
    public partial class PodmiotForm : Form
    {
        private Podmiot Podmiot;
        private Module Module = Module.GetInstance();
        public PodmiotForm(Podmiot _podmiot)
        {
            this.Podmiot = _podmiot;
            InitializeComponent();
        }

        private void PodmiotForm_Load(object sender, EventArgs e)
        {
            if(Podmiot.Id == 0)
            {
                this.Text += " (NOWY)";
                
            }
            PrepareForm();
        }

        private void AddKontakt_Click(object sender, EventArgs e)
        {
            CollectForm();
            Kontakt kontakt = new Kontakt();
            kontakt.Podmiot = Podmiot;
            KontaktForm form = new KontaktForm(kontakt);
            form.ShowDialog();
            KontaktyGrid.AutoGenerateColumns = false;
            KontaktyGrid.DataSource = Podmiot.Kontakty.ToList();
            KontaktyGrid.Refresh();
        }

        private void KontaktyTab_Enter(object sender, EventArgs e)
        {
            AddKontakt.Visible = true;
            AddAdres.Visible = false;
        }

        private void KontaktyTab_Leave(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void OgólneTab_Enter(object sender, EventArgs e)
        {
            AddKontakt.Visible = false;
            AddAdres.Visible = true;
        }

        private void AddAdres_Click(object sender, EventArgs e)
        {
            CollectForm();
            Adres adres = new Adres();
            adres.Podmiot = Podmiot;
            AdresForm form = new AdresForm(adres);
            form.ShowDialog();
            AdresyGrid.DataSource = Podmiot.Adresy.ToList();
            AdresyGrid.Refresh();
            
        }

        /// <summary>
        /// Wyciąga dane z obiektu do okienka
        /// </summary>
        private void PrepareForm()
        {
            textBox1.Text = Podmiot.Nazwa;
            AdresyGrid.AutoGenerateColumns = false;
            AdresyGrid.DataSource = Podmiot.Adresy.ToList();
            Pigeon.Class.GridView.SetGridSettings(ref AdresyGrid);
            AdresyGrid.Refresh();
            KontaktyGrid.AutoGenerateColumns = false;
            KontaktyGrid.DataSource = Podmiot.Kontakty.ToList();
            Pigeon.Class.GridView.SetGridSettings(ref KontaktyGrid);
            KontaktyGrid.Refresh();
            if(Podmiot.Obrazek != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(Podmiot.Obrazek));

            foreach(DataGridViewColumn col in AdresyGrid.Columns)
            {
                var item = new ToolStripMenuItem();
                item.CheckOnClick = true;
                item.Text = col.HeaderText;
                item.Checked = col.Visible;
                item.CheckedChanged += (object sender, EventArgs e) => {
                    col.Visible = item.Checked;
                };
                tabelaAdresyToolStripMenuItem.DropDownItems.Add(item);
            }

            foreach (DataGridViewColumn col in KontaktyGrid.Columns)
            {
                var item = new ToolStripMenuItem();
                item.CheckOnClick = true;
                item.Text = col.HeaderText;
                item.Checked = col.Visible;
                item.CheckedChanged += (object sender, EventArgs e) => {
                    col.Visible = item.Checked;
                };
                tabelaKontaktyToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        /// <summary>
        /// Zbiera informacje z okienka do obiektu
        /// </summary>
        private void CollectForm()
        {
            Podmiot.Nazwa = textBox1.Text;
            ImageConverter converter = new ImageConverter();
            if(pictureBox1.Image != null)
            Podmiot.Obrazek = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectForm();
            if(Podmiot.Id == 0)
            {
               Module.Podmioty.Add(Podmiot);
            }
            try {
                Module.SaveChanges();
            }catch(System.Data.Entity.Validation.DbEntityValidationException exc)
            {
                MessageBox.Show(exc.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage);
            }catch(System.Data.Entity.Infrastructure.DbUpdateException exc)
            {
                MessageBox.Show(exc.InnerException.ToString());
            }
            this.Close();
        }

        private void AdresyGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Adres adres = AdresyGrid.Rows[e.RowIndex].DataBoundItem as Adres;
            AdresForm form = new AdresForm(adres);
            form.ShowDialog();
            AdresyGrid.DataSource = Podmiot.Adresy.ToList();
            AdresyGrid.Refresh();
        }

        private void KontaktyGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Kontakt kontakt = KontaktyGrid.Rows[e.RowIndex].DataBoundItem as Kontakt;
            KontaktForm form = new KontaktForm(kontakt);
            form.ShowDialog();
            KontaktyGrid.DataSource = Podmiot.Kontakty.ToList();
            KontaktyGrid.Refresh();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = dialog.OpenFile();
                try {
                    pictureBox1.Image = Image.FromStream(file);
                    pictureBox1.Refresh();
                }catch(Exception exc)
                {

                }
            }
        }

        private void KontaktyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdresyGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = AdresyGrid.HitTest(e.X, e.Y).RowIndex;
                if (index >= 0)
                {
                    AdresyGrid.Rows[index].Selected = true;
                    CxMenu.Show(Cursor.Position);
                }
            }
        }

        private void formularzToolStripMenuItem_Click(object sender, EventArgs e)
        {
                foreach(DataGridViewRow row in AdresyGrid.SelectedRows)
                {
                    Adres adres = row.DataBoundItem as Adres;
                    AdresForm form = new AdresForm(adres);
                    form.ShowDialog();
                    break;
                }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AdresyGrid.SelectedRows)
            {
                Adres adres = row.DataBoundItem as Adres;
                Module.Adresy.Remove(adres);
            }
            Module.SaveChanges();
            AdresyGrid.DataSource = Module.Adresy.ToList();
            AdresyGrid.Refresh();
        }

        private void formularzToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in KontaktyGrid.SelectedRows)
            {
                Kontakt kontakt = row.DataBoundItem as Kontakt;
                KontaktForm form = new KontaktForm(kontakt);
                form.ShowDialog();
                break;
            }
        }

        private void KontaktyGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = KontaktyGrid.HitTest(e.X, e.Y).RowIndex;
                if (index >= 0)
                {
                    KontaktyGrid.Rows[index].Selected = true;
                    CxKontaktMenu.Show(Cursor.Position);
                }
            }
        }

        private void usuńToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in KontaktyGrid.SelectedRows)
            {
                Kontakt kontakt = row.DataBoundItem as Kontakt;
                Module.Kontakty.Remove(kontakt);
            }
            Module.SaveChanges();
            KontaktyGrid.DataSource = Module.Kontakty.ToList();
            KontaktyGrid.Refresh();
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pigeon.Class.GridView.SaveSettingsFromGrid(AdresyGrid);
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pigeon.Class.GridView.SaveSettingsFromGrid(KontaktyGrid);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            zapiszUstawieniaTabeliToolStripMenuItem_Click(sender, e);
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            zapiszUstawieniaTabeliToolStripMenuItem1_Click(sender, e);
        }
    }
}
