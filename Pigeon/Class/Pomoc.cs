using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pigeon.Class
{
    class Pomoc
    {
        #region TREŚĆ
        private static string infoText = "Application name: Pigeon \n" + 
            "Version: 1.0 \n" +
            "Created By: \n\n" + 
            "   - Nikodem Kowalec \n" + 
            "   - Mikołaj Karczewski \n\n" + 
            "Aplikacja przygotowana na zaliczenie projektu \n" + 
            "Programowanie Obiektowe - CDV";
        #endregion

        /// <summary>
        /// Dodaje do przekazanego Elementu, element informacje
        /// </summary>
        /// <param name="_item"></param>
        public static void AddPomocItemsToMenuStripItem(ref ToolStripMenuItem _item)
        {
            var newItem = new ToolStripMenuItem();
            newItem.Text = "Informacje";
            newItem.Click += NewItem_Click;
            _item.DropDownItems.Add(newItem);
        }

        private static void NewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(infoText, "Pigeon - Informacje", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
