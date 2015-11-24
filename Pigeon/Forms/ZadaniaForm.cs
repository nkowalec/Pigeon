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

namespace Pigeon.Forms
{
    public partial class ZadaniaForm : Form
    {
        Module Module = Module.GetInstance();
        public ZadaniaForm()
        {
            PleaseWaitForm form = new PleaseWaitForm();
            form.Show();
            InitializeComponent();
            ZadaniaGrid.AutoGenerateColumns = false;
            ZadaniaGrid.DataSource = Module.Zadania.ToList();
            ZadaniaGrid.Refresh();

            GridView.SetGridSettings(ref ZadaniaGrid);
            GridView.PrepareMenuStripItemGridColumns(ref ZadaniaGrid, ref tabelaZadańToolStripMenuItem);
            form.Close();
        }

        private void ZadaniaForm_Load(object sender, EventArgs e)
        {
            Pomoc.AddPomocItemsToMenuStripItem(ref pomocToolStripMenuItem);
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pigeon.Class.GridView.SaveSettingsFromGrid(ZadaniaGrid);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadanie zad = new Zadanie();
            zad.Data = DateTime.Now;
            ZadanieForm form = new ZadanieForm(zad);
            form.ShowDialog();

            ZadaniaGrid.DataSource = Module.Zadania.ToList();
            ZadaniaGrid.Refresh();
        }

        private void ZadaniaGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Zadanie zad = ZadaniaGrid.Rows[e.RowIndex].DataBoundItem as Zadanie;
            ZadanieForm form = new ZadanieForm(zad);
            form.ShowDialog();
           
            ZadaniaGrid.DataSource = Module.Zadania.ToList();
            ZadaniaGrid.Refresh();
        }

        private void formularzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ZadaniaGrid.SelectedRows)
            {
                Zadanie zad = row.DataBoundItem as Zadanie;

                ZadanieForm form = new ZadanieForm(zad);
                form.ShowDialog();

                break;
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ZadaniaGrid.SelectedRows)
            {
                Zadanie zad = row.DataBoundItem as Zadanie;
                Module.Zadania.Remove(zad);
            }
            Module.SaveChanges();
            ZadaniaGrid.DataSource = Module.Zadania.ToList();
            ZadaniaGrid.Refresh();
        }

        private void zapiszUstawieniaTabeliToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GridView.SaveSettingsFromGrid(ZadaniaGrid);
        }

        private void ZadaniaGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = ZadaniaGrid.HitTest(e.X, e.Y).RowIndex;
                if (index >= 0)
                {
                    ZadaniaGrid.Rows[index].Selected = true;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
