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
    public partial class GlowneProgram : Form
    {
        public GlowneProgram()
        {
            InitializeComponent();
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Podmioty_Click(object sender, EventArgs e)
        {
            PodmiotyGlowne form = new PodmiotyGlowne();
            form.Show();
        }

        private void Opcje_Click(object sender, EventArgs e)
        {
            ConfigForm form = new ConfigForm();
            form.ShowDialog();
        }
    }
}
