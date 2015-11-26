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
    public partial class ZadanieForm : Form, IObjectForm
    {
        Module Module = Module.GetInstance();
        Zadanie Zadanie;
        public ZadanieForm(Zadanie _zadanie)
        {
            InitializeComponent();
            Zadanie = _zadanie;

            if (Zadanie.Id == 0)
                this.Text += " (NOWE)";

            PrepareForm();
        }

        public void BlockForm()
        {
            PodmiotCombo.Enabled = false;
            NazwaText.Enabled = false;
            dateTimePicker1.Enabled = false;
            PrzypCombo.Enabled = false;
            PrzedText.Enabled = false;
            OpisText.Enabled = false;
        }

        public void CollectForm()
        {
            if (PodmiotCombo.SelectedItem != null)
                Zadanie.Podmiot = PodmiotCombo.SelectedItem as Podmiot;
            Zadanie.Nazwa = NazwaText.Text;
            Zadanie.Data = dateTimePicker1.Value;
            if(PrzypCombo.SelectedItem != null)
                Zadanie.Przypomnienie = (TypPrzypomnienia)PrzypCombo.SelectedItem;
            if (PrzedText.Text != "")
                Zadanie.Wyprzedzenie = int.Parse(PrzedText.Text);
            Zadanie.Opis = OpisText.Text;
        }

        public void PrepareForm()
        {

            PodmiotCombo.DataSource = Module.Podmioty.ToList();
            if(Zadanie.Podmiot != null)
            {
                PodmiotCombo.SelectedItem = Zadanie.Podmiot;
            }

            NazwaText.Text = Zadanie.Nazwa;
            if (Zadanie.Data != null)
            {
                dateTimePicker1.Value = new DateTime(Zadanie.Data.Year, Zadanie.Data.Month, Zadanie.Data.Day, Zadanie.Data.Hour, Zadanie.Data.Minute, Zadanie.Data.Second);
            }
            PrzypCombo.DataSource = Enum.GetValues(typeof(TypPrzypomnienia));
            PrzypCombo.SelectedItem = Zadanie.Przypomnienie;

            if (Zadanie.Przypomnienie == TypPrzypomnienia.Brak) PrzedText.Enabled = false;
            PrzedText.Text = Zadanie.Wyprzedzenie.ToString();
            OpisText.Text = Zadanie.Opis;
        }

        private void ZadanieForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectForm();
            if (Zadanie.Id == 0)
                Module.Zadania.Add(Zadanie);

            Module.SaveChanges();

            Close();
        }

        private void PrzypCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if((TypPrzypomnienia)PrzypCombo.SelectedItem == TypPrzypomnienia.Brak)
            {
                PrzedText.Enabled = false;
            }
            else
            {
                PrzedText.Enabled = true;
            }
        }
    }
}
