using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pigeon.Forms;
using System.Timers;

namespace Pigeon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Notifications().StartNotification();
            Application.Run(new GlowneProgram());
        }
    }

    class Notifications
    {
        NotificationForm notiForm = null;
        Module Module = Module.GetInstance();
        internal void StartNotification()
        { 
            System.Timers.Timer timer = new System.Timers.Timer(60000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var powiadomienia = Module.Zadania.Where(x => x.IsNotificate == false && x.Przypomnienie != TypPrzypomnienia.Brak);
            var teraz = DateTime.Now;

            Action action = () => { notiForm.Close(); };

            List<Zadanie> lista = new List<Zadanie>();

            foreach(Zadanie zad in powiadomienia)
            {
                bool noti = false;

                if(zad.Przypomnienie == TypPrzypomnienia.Dni)
                {
                    if(zad.Data.AddDays(-zad.Wyprzedzenie) <= teraz) noti = true;
                }
                else if(zad.Przypomnienie == TypPrzypomnienia.Godziny)
                {
                    if (zad.Data.AddHours(-zad.Wyprzedzenie) <= teraz) noti = true;
                }else if(zad.Przypomnienie == TypPrzypomnienia.Minuty)
                {
                    if (zad.Data.AddMinutes(-zad.Wyprzedzenie) <= teraz) noti = true;
                }else if(zad.Przypomnienie == TypPrzypomnienia.Tygodnie)
                {
                    if (zad.Data.AddDays(-zad.Wyprzedzenie*7) <= teraz) noti = true;
                }

                if (zad.IsNotificate) noti = false;

                if (noti)
                {
                    lista.Add(zad);
                }
            }

            if(lista.Count > 0)
            {
                if (notiForm == null)
                {
                    notiForm = new NotificationForm(lista);
                    notiForm.ShowDialog();
                }
                else
                {
                    try
                    {
                        notiForm.Invoke(action);
                    }
                    catch { }
                    notiForm = new NotificationForm(lista);
                    notiForm.ShowDialog();
                }
            }
        }
    }
}
