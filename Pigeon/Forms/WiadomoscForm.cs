using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pigeon.Class;
using System.IO;

namespace Pigeon.Forms
{
    public partial class WiadomoscForm : Form, IObjectForm
    {
        Module Module = Module.GetInstance();
        Wiadomość Wiadomość;
        public WiadomoscForm(Wiadomość _wiad)
        {
            this.Wiadomość = _wiad;
            InitializeComponent();
        }

        public void CollectForm()
        {
            if (AdresatCombo.SelectedItem != null)
                Wiadomość.Adresat = AdresatCombo.SelectedItem as Kontakt;
            Wiadomość.Temat = textBox1.Text;
            Wiadomość.Treść = textBox2.Text;
        }

        public void PrepareForm()
        {
            textBox1.Text = Wiadomość.Temat;
            textBox2.Text = Wiadomość.Treść;
            if (Wiadomość.Adresat != null)
            {
                AdresatCombo.Items.Add(Wiadomość.Adresat);
                AdresatCombo.SelectedItem = Wiadomość.Adresat;
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Wiadomość.AdresaciDW.ToList();
            dataGridView1.Refresh();

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = Wiadomość.Załączniki.ToList();
            dataGridView2.Refresh();

            if (Wiadomość.Status == StatusWiadomosci.Robocza)
            {
                SaveSendBtn.Enabled = true;
                button1.Enabled = false;
            }
            else
            {
                SaveSendBtn.Enabled = false;
                button1.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                dataGridView1.Enabled = false;
                button2.Enabled = false;
                AddAdres.Enabled = false;
                AdresatCombo.Enabled = false;
            }
        }

        private void WiadomoscForm_Load(object sender, EventArgs e)
        {
            if(Wiadomość.Id == 0)
            {
                this.Text += " (NOWA)";
            }

            PrepareForm();
        }

        private void AddAdres_Click(object sender, EventArgs e)
        {
            CollectForm();
            AdresatDW adresat = new AdresatDW();
            adresat.Wiadomość = Wiadomość;

            AdresatForm form = new AdresatForm(adresat);
            form.ShowDialog();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Wiadomość.AdresaciDW.ToList<AdresatDW>();
            dataGridView1.Refresh();

            
        }

        private void AdresatCombo_DropDown(object sender, EventArgs e)
        {
            AdresatForm form = new AdresatForm(this.AdresatCombo);
            form.ShowDialog();
            AdresatCombo.AllowDrop = false;
            this.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var adresat = dataGridView1.Rows[e.RowIndex].DataBoundItem as AdresatDW;
            AdresatForm form = new AdresatForm(adresat);
            form.ShowDialog();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Wiadomość.AdresaciDW.ToList();
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                CollectForm();
                foreach(string file in dialog.FileNames)
                {
                    System.IO.FileInfo info = new System.IO.FileInfo(file);
                    Załącznik att = new Załącznik() {
                        Nazwa = info.Name,
                        Wiadomość = Wiadomość,
                    };
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (var stream = info.Open(FileMode.Open))
                        {
                            stream.CopyTo(ms);
                            stream.Dispose();
                            att.Dane = ms.ToArray();
                            ms.Dispose();
                        }
                    }

                    Module.Załączniki.Add(att);
                }
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = Wiadomość.Załączniki.ToList();
                dataGridView2.Refresh();
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveSendBtn_Click(object sender, EventArgs e)
        {
            CollectForm();
            try
            {
                Wiadomość.Wyslij();
                Wiadomość.Status = StatusWiadomosci.Wyslana;
                if(Wiadomość.Id == 0)
                {
                    Module.Wiadomości.Add(Wiadomość);
                }
                Module.SaveChanges();

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Napotkano błąd podczas wysyłania wiadomości, sprawdź konfigurację i połączenie internetowe: \n" + ex.Message);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Wiadomość.Wyslij();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano błąd podczas wysyłania wiadomości, sprawdź konfigurację i połączenie internetowe: \n" + ex.Message);
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                AdresatDW adres = row.DataBoundItem as AdresatDW;
                Module.AdresaciDW.Remove(adres);
            }
            Module.SaveChanges();
            dataGridView1.DataSource = Module.AdresaciDW.ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (index >= 0)
                {
                    dataGridView1.Rows[index].Selected = true;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void usuńToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                Załącznik adres = row.DataBoundItem as Załącznik;
                Module.Załączniki.Remove(adres);
            }
            Module.SaveChanges();
            dataGridView2.DataSource = Module.Załączniki.ToList();
            dataGridView2.Refresh();
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = dataGridView2.HitTest(e.X, e.Y).RowIndex;
                if (index >= 0)
                {
                    dataGridView2.Rows[index].Selected = true;
                    contextMenuStrip2.Show(Cursor.Position);
                }
            }
        }
    }
}
