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
using System.Diagnostics;

namespace Pigeon.Forms
{
    public partial class AdresatForm : Form, IObjectForm
    {
        Module Module = Module.GetInstance();
        object Adres;
        Type typObjektu;
        public AdresatForm(AdresatDW _adresat)
        {
            this.Adres = _adresat;
            typObjektu = typeof(AdresatDW);
            InitializeComponent();
        }

        public AdresatForm(ComboBox _kontakt)
        {
            this.Adres = _kontakt;
            typObjektu = typeof(ComboBox);
            InitializeComponent();
        }

        public void CollectForm()
        {
            if(typObjektu == typeof(AdresatDW))
            {
                var Adresat = (AdresatDW)Adres;
                Adresat.Kontakt = (Kontakt)comboBox2.SelectedItem;
            }
            else
            {
                var combo = (ComboBox)Adres;
                combo.Items.Add(comboBox2.SelectedItem);
                combo.SelectedItem = comboBox2.SelectedItem;
            }
        }

        public void PrepareForm()
        {
            if(Adres is AdresatDW)
            {
                var Adresat = Adres as AdresatDW;
                comboBox1.SelectedItem = Adresat.Kontakt.Podmiot;
                comboBox2.Enabled = true;
                comboBox2.SelectedItem = Adresat.Kontakt;
            }
            else
            {
                var Kontakt = ((ComboBox)Adres).SelectedItem as Kontakt;
                comboBox1.SelectedItem = Kontakt.Podmiot;
                comboBox2.Enabled = true;
                comboBox2.SelectedItem = Kontakt;
            }
        }

        private void AdresatForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Module.Podmioty.ToList<Podmiot>();
            comboBox1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox2.DataSource = ((Podmiot)comboBox1.SelectedItem).Kontakty.ToList<Kontakt>().Where(x => x.Nazwa == TypKontaktu.Email_Prywatny || x.Nazwa == TypKontaktu.Email_Służbowy).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectForm();
            if(typObjektu == typeof(AdresatDW))
            {
                if(((AdresatDW)Adres).Id == 0)
                {
                    Module.AdresaciDW.Add((AdresatDW)Adres);
                }
                try {
                    Module.SaveChanges();
                }catch(System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    MessageBox.Show(ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage);
                }
            }

            this.Close();
        }
    }
}
