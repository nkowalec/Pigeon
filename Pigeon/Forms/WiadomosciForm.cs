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
        public WiadomosciForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wiadomość wiad = new Wiadomość();
            wiad.Status = StatusWiadomosci.Robocza;

            WiadomoscForm form = new WiadomoscForm(wiad);
            form.ShowDialog();
        }
    }
}
