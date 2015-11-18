using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pigeon.Properties;

namespace Pigeon
{
    public partial class PodmiotyGlowne : Form
    {
        Module module = Module.GetInstance();
        public PodmiotyGlowne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PodmiotyGrid.AutoGenerateColumns = false;
            PodmiotyGrid.DataSource = module.Podmioty.ToList<Podmiot>();
            Pigeon.Class.GridView.SetGridSettings(ref PodmiotyGrid);
            PodmiotyGrid.Refresh();
        }

        private void AddPodmiot_Click(object sender, EventArgs e)
        {
            Podmiot podmiot = new Podmiot();
            PodmiotForm form = new PodmiotForm(podmiot);
            form.ShowDialog();
            PodmiotyGrid.DataSource = module.Podmioty.ToList();
            PodmiotyGrid.Refresh();
        }

        private void PodmiotyGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Podmiot podmiot = PodmiotyGrid.Rows[e.RowIndex].DataBoundItem as Podmiot;
            PodmiotForm form = new PodmiotForm(podmiot);
            form.ShowDialog();
            PodmiotyGrid.DataSource = module.Podmioty.ToList();
            PodmiotyGrid.Refresh();
        }

        private void PodmiotyGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = PodmiotyGrid.HitTest(e.X, e.Y).RowIndex;
                if (index >= 0) {
                    PodmiotyGrid.Rows[index].Selected = true;
                    CxMenu.Show(Cursor.Position);
                }
            }
        }

        private void formularzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in PodmiotyGrid.SelectedRows)
            {
                Podmiot podmiot = row.DataBoundItem as Podmiot;

                PodmiotForm form = new PodmiotForm(podmiot);
                form.ShowDialog();

                break;
            }

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PodmiotyGrid.SelectedRows)
            {
                Podmiot podmiot = row.DataBoundItem as Podmiot;
                module.Podmioty.Remove(podmiot);
            }
            module.SaveChanges();
            PodmiotyGrid.DataSource = module.Podmioty.ToList();
            PodmiotyGrid.Refresh();
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pigeon.Class.GridView.SaveSettingsFromGrid(PodmiotyGrid);
        }
    }
}
