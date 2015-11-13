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
    public partial class KontaktForm : Form
    {
        private Kontakt Kontakt { get; set; }
        private Module Module = Module.GetInstance();
        public KontaktForm(Kontakt _kontakt)
        {
            this.Kontakt = _kontakt;
            InitializeComponent();
        }

        private void KontaktForm_Load(object sender, EventArgs e)
        {
            if(Kontakt.Id == 0)
            {
                this.Text += " (NOWY)";
            }
            PrepareForm();
        }

        private void PrepareForm()
        {
            this.TypKontaktu.DataSource = Enum.GetValues(typeof(TypKontaktu));
            this.TypKontaktu.SelectedItem = Kontakt.Nazwa;
            this.WartoscText.Text = Kontakt.Wartość;
        }

        private void CollectForm()
        {
            Kontakt.Nazwa = (TypKontaktu)TypKontaktu.SelectedItem;
            Kontakt.Wartość = WartoscText.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectForm();
            if(Kontakt.Id == 0)
            {
                Module.Kontakty.Add(Kontakt);
            }
            try {
                Module.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException exc)
            {
                MessageBox.Show(exc.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException exc)
            {
                MessageBox.Show(exc.InnerException.ToString());
            }
            this.Close();
        }
    }
}
