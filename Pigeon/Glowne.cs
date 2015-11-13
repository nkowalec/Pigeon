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
    public partial class Glowne : Form
    {
        Module module = Module.GetInstance();
        public Glowne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PodmiotyGrid.AutoGenerateColumns = false;
            PodmiotyGrid.DataSource = module.Podmioty.ToList<Podmiot>();
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

    }
}
