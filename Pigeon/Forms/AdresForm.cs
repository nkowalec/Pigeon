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
    public partial class AdresForm : Form
    {
        private Adres Adres;
        private Module Module = Module.GetInstance();
        public AdresForm(Adres _adres)
        {
            this.Adres = _adres;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AdresForm_Load(object sender, EventArgs e)
        {
            this.WojCombo.DataSource = Enum.GetValues(typeof(Wojewodztwo));
            this.TypCombo.DataSource = Enum.GetValues(typeof(TypAdresu));
            if(Adres.Id == 0)
            {
                this.Text += " (NOWY)";
            }
                PrepareForm();
            
        }

        /// <summary>
        /// Umieszcza informacje z obiektu w oknie
        /// </summary>
        private void PrepareForm()
        {
            TypCombo.SelectedItem = Adres.Typ;
            WojCombo.SelectedItem = Adres.Wojewodztwo;
            MiastoText.Text = Adres.Miasto;
            UlicaText.Text = Adres.Ulica;
            KodText.Text = Adres.KodPocztowy;
            DomText.Text = Adres.NrDomu;
            LokalText.Text = Adres.NrLokalu;
            KrajText.Text = Adres.Kraj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectForm();
            if (Adres.Id == 0)
                Module.Adresy.Add(Adres);

            Module.SaveChanges();

            this.Close();
        }

        /// <summary>
        /// Zbiera informacje z okna do obiektu
        /// </summary>
        private void CollectForm()
        {
            Adres.Typ = (TypAdresu)TypCombo.SelectedItem;

            if(WojCombo.SelectedItem != null)
                Adres.Wojewodztwo = (Wojewodztwo)WojCombo.SelectedItem;
            Adres.Miasto = MiastoText.Text;
            Adres.Ulica = UlicaText.Text;
            Adres.KodPocztowy = KodText.Text;
            Adres.NrDomu = DomText.Text;
            Adres.NrLokalu = LokalText.Text;
            Adres.Kraj = KrajText.Text;
        }
    }
}
