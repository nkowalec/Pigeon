﻿using System;
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
using System.Text.RegularExpressions;

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
            var komunikat = "";
            var email = emailText.Text;
            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
 
            if (!match.Success)
            {
                komunikat += email + " - Nie jest poprawną formą maila! \n";
            }
            

            if (komunikat != "" )
            {
                MessageBox.Show(komunikat);
            }
            else
            {
                Config.Update();

                this.Close();
            }


        }

        #endregion

        #region MyMethods
        /// <summary>
        /// Wrzuca dane z obiektu do formsa
        /// </summary>
        public void PrepareForm()
        {
            emailText.Text = Config.Email;
            loginText.Text = Config.Login;
            passText.Text = Config.GetPass();
            smtpAdresText.Text = Config.SMTP_Adres;
            smtpPortText.Text = Config.SMTP_Port.ToString();
            checkBox1.Checked = Config.SSL;
        }

        /// <summary>
        /// Wrzuca dane z formsa do obiektu
        /// </summary>
        public void CollectForm()
        {
            Config.Email = emailText.Text;
            Config.Login = loginText.Text;
            Config.Pass = passText.Text;
            Config.SMTP_Adres = smtpAdresText.Text;
            Config.SMTP_Port = int.Parse(smtpPortText.Text);
            Config.SSL = checkBox1.Checked;
        }
        #endregion
    }
}
