using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pigeon.Forms
{
    public partial class WiadomosciForm : Form
    {
        Module Module = Module.GetInstance();
        public WiadomosciForm()
        {
            InitializeComponent();
            PleaseWaitForm form = new PleaseWaitForm();
            form.Show();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Module.Wiadomości.ToList();
            dataGridView1.Refresh();

            Pigeon.Class.Pomoc.AddPomocItemsToMenuStripItem(ref pomocToolStripMenuItem);
            Pigeon.Class.GridView.SetGridSettings(ref dataGridView1);
            Pigeon.Class.GridView.PrepareMenuStripItemGridColumns(ref dataGridView1, ref tabelaWiadomościToolStripMenuItem);
            form.Close();
        }

        #region EVENTS
        private void button2_Click(object sender, EventArgs e)
        {
            Wiadomość wiad = new Wiadomość();
            wiad.Status = StatusWiadomosci.Robocza;

            WiadomoscForm form = new WiadomoscForm(wiad);
            form.ShowDialog();

            dataGridView1.DataSource = Module.Wiadomości.ToList();
            dataGridView1.Refresh();
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pigeon.Class.GridView.SaveSettingsFromGrid(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var wiadomosc = dataGridView1.Rows[e.RowIndex].DataBoundItem as Wiadomość;

            WiadomoscForm form = new WiadomoscForm(wiadomosc);
            form.ShowDialog();

            dataGridView1.DataSource = Module.Wiadomości.ToList();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void WiadomosciForm_Load(object sender, EventArgs e)
        {

        }
    }
}
