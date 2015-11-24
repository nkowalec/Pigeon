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

        #region EVENTS
        private void Close_Click(object sender, EventArgs e)    //zamyka Aplikację
        {
            Application.Exit();
        }

        private async void Podmioty_Click(object sender, EventArgs e)   //otwiera okno Podmiotów
        {
            PodmiotyGlowne form = new PodmiotyGlowne();
            form.Show();
        }

        private void Opcje_Click(object sender, EventArgs e)    //otwiera dialog konfiguracji
        {
            ConfigForm form = new ConfigForm();
            form.ShowDialog();
        }

        #endregion

        private void Wiadomosci_Click(object sender, EventArgs e)
        {
            WiadomosciForm form = new WiadomosciForm();
            form.Show();
        }

        private void Zadania_Click(object sender, EventArgs e)
        {
            ZadaniaForm form = new ZadaniaForm();
            form.Show();
        }
    }
}
