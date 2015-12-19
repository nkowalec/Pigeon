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
    public partial class NotificationForm : Form
    {
        public NotificationForm(List<Zadanie> _zadania)
        {
            InitializeComponent();
            dataGridView1.DataSource = _zadania;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Zadanie zad in (List<Zadanie>)dataGridView1.DataSource)
            {
                zad.IsNotificate = true;
            }

            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var zadanie = dataGridView1.Rows[e.RowIndex].DataBoundItem as Zadanie;
            ZadanieForm form = new ZadanieForm(zadanie);
            form.BlockForm();
            form.ShowDialog();
        }
    }
}
