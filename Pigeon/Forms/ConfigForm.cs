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
    public partial class ConfigForm : Form, IObjectForm
    {
        private Config Config = Config.GetInstance();
        public ConfigForm()     //w konstuktorze zostaje przygotowany forms z danymi
        {
            InitializeComponent();

            PrepareForm();
        }

        #region EVENTS
        private void button1_Click(object sender, EventArgs e)
        {
            CollectForm();
            Config.Update();

            this.Close();
        }

        #endregion

        #region MyMethods
        /// <summary>
        /// Wrzuca dane z obiektu do formsa
        /// </summary>
        void IObjectForm.PrepareForm()
        {
            emailText.Text = Config.Email;
            loginText.Text = Config.Login;
            passText.Text = Config.GetPass();
            smtpAdresText.Text = Config.SMTP_Adres;
            smtpPortText.Text = Config.SMTP_Port.ToString();
        }

        /// <summary>
        /// Wrzuca dane z formsa do obiektu
        /// </summary>
        void IObjectForm.CollectForm()
        {
            Config.Email = emailText.Text;
            Config.Login = loginText.Text;
            Config.Pass = passText.Text;
            Config.SMTP_Adres = smtpAdresText.Text;
            Config.SMTP_Port = int.Parse(smtpPortText.Text);
        }
        #endregion
    }
}
