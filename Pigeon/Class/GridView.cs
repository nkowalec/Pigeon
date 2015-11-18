using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace Pigeon.Class
{
    /// <summary>
    /// Klasa obsługująca ustawienia widoczności kolumn gridów
    /// </summary>
    [XmlRoot]
    public class GridView
    {
        private static string Path(string GridName) => System.IO.Path.Combine(@"Config\" + $"{GridName}.grid.xml");
        [XmlElement("Grid")]
        public string GridName { get; set; }
        [XmlElement]
        public List<GridColumnVisible> ColumnVisible { get; set; }

        /// <summary>
        /// Zapisuje ustawienia widoczności grida do pliku XML
        /// </summary>
        /// <param name="_grid"></param>
        public static void SaveSettingsFromGrid(DataGridView _grid)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GridView));
            GridView view = new GridView();
            view.GridName = _grid.Name;
            List<GridColumnVisible> lista = new List<GridColumnVisible>();
            foreach(DataGridViewColumn col in _grid.Columns)
            {
                var xCol = new GridColumnVisible();
                xCol.ColName = col.Name;
                xCol.Visible = col.Visible;
                lista.Add(xCol);
            }
            view.ColumnVisible = lista;
            if (!Directory.Exists("Config")) Directory.CreateDirectory("Config");
            using(var file = File.Open(Path(view.GridName), FileMode.OpenOrCreate))
            {
                using (TextWriter writer = new StreamWriter(file))
                {
                    writer.Write("");
                    serializer.Serialize(writer, view);
                }
                string lastLine = File.ReadLines(file.Name).Last();
                if (lastLine.EndsWith(">>"))    //Podczas serializacji, zdarzał się błąd, który dodawał dodatkowy '>' na końcu
                {                               //To usuwa ten dodatkowy znak jeśli się pojawi
                    using(var file2 = File.Open(Path(view.GridName), FileMode.Open))
                    {
                        file2.SetLength(file2.Length - 1);
                    }   
                }
                
            }
        }

        /// <summary>
        /// Ustawia widoczności kolumn grida na podstawie danych pobranych z pliku XML
        /// </summary>
        /// <param name="_grid"></param>
        public static void SetGridSettings(ref DataGridView _grid)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GridView));
            if(File.Exists(Path(_grid.Name)))
            {
                using(TextReader reader = new StreamReader(Path(_grid.Name)))
                {
                    GridView view = serializer.Deserialize(reader) as GridView;
                    foreach (GridColumnVisible colVisible in view.ColumnVisible)
                    {
                        foreach(DataGridViewColumn col in _grid.Columns)
                        {
                            if(colVisible.ColName == col.Name)
                            {
                                col.Visible = colVisible.Visible;
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Dodaje do elementu "ToolStripMenuItem" elementy sterujące widocznością kolumn przekazanego grida
        /// </summary>
        /// <param name="_grid"></param>
        /// <param name="_menuItem"></param>
        public static void PrepareMenuStripItemGridColumns(ref DataGridView _grid, ref ToolStripMenuItem _menuItem)
        {
            foreach (DataGridViewColumn col in _grid.Columns)
            {
                var item = new ToolStripMenuItem();
                item.CheckOnClick = true;
                item.Text = col.HeaderText;
                item.Checked = col.Visible;
                item.CheckedChanged += (object sender, EventArgs e) => {
                    col.Visible = item.Checked;
                };
                _menuItem.DropDownItems.Add(item);
            }
        }
    }

    public class GridColumnVisible
    {
        [XmlElement]
        public string ColName { get; set; }
        [XmlElement]
        public bool Visible { get; set; }
    }
}
