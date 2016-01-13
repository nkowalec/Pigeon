using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pigeon.Class;
using Pigeon;
using System.Text.RegularExpressions;

namespace Pigeon.Forms
{
    public partial class KontaktForm : Form, IObjectForm
    {
        private Kontakt Kontakt { get; set; }
        private Module Module = Module.GetInstance();
        public KontaktForm(Kontakt _kontakt)    //konstruktor przyjmuje obiekt, z którym będzie pracował
        {
            this.Kontakt = _kontakt;
            InitializeComponent();
        }

        #region EVENTS
        private void KontaktForm_Load(object sender, EventArgs e)
        {
            if(Kontakt.Id == 0)
            {
                this.Text += " (NOWY)";
            }
            PrepareForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectForm();
            var komunikat = "";
   
            if (this.TypKontaktu.SelectedItem == TypKontaktu.Email_Prywatny|| this.TypKontaktu.SelectedItem == TypKontaktu.Email_Sluzbowy)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(WartoscText.Text);
                if (!match.Success)
                {
                    komunikat += WartoscText + " - Nie jest poprawną formą maila! \n";
                }
                if (komunikat != "")
                {
                    MessageBox.Show(komunikat);
                }
                else
                {
                    if (Kontakt.Id == 0)
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
            else
            {
                Regex regex = new Regex(@"^([0-9]{9})$");
                Match match = regex.Match(WartoscText.Text);
                if (!match.Success)
                {
                    komunikat += WartoscText + " - Nie jest poprawną formą numeru telefonu! \n (przykładowo: 123456789) \n";
                }
                if (komunikat != "")
                {
                    MessageBox.Show(komunikat);
                }
                else
                {
                    if (Kontakt.Id == 0)
                    {
                        Module.Kontakty.Add(Kontakt);
                    }
                    try
                    {
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
        #endregion

        #region MyMethods
        /// <summary>
        /// Wrzuca dane z obiektu do formsa
        /// </summary>
        public void PrepareForm()
        {
            this.TypKontaktu.DataSource = Enum.GetValues(typeof(TypKontaktu));
            this.TypKontaktu.SelectedItem = Kontakt.Nazwa;
            this.WartoscText.Text = Kontakt.Wartość;
        }

        /// <summary>
        /// Wrzuca dane z formsa do obiektu
        /// </summary>
        public void CollectForm()
        {
            Kontakt.Nazwa = (TypKontaktu)TypKontaktu.SelectedItem;
            Kontakt.Wartość = WartoscText.Text;
        }
        #endregion
    }
}
