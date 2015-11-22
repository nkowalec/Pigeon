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
    public partial class WiadomoscForm : Form, IObjectForm
    {
        Wiadomość Wiadomość;
        public WiadomoscForm(Wiadomość _wiad)
        {
            this.Wiadomość = _wiad;
            InitializeComponent();
        }

        void IObjectForm.CollectForm()
        {
            
        }

        void IObjectForm.PrepareForm()
        {
            
        }

        private void WiadomoscForm_Load(object sender, EventArgs e)
        {
            if(Wiadomość.Id == 0)
            {
                this.Text += " (NOWA)";
            }
        }
    }
}
