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
    [XmlRoot]
    public class GridView
    {
        private static string Path(string GridName) => System.IO.Path.Combine(@"Config\" + $"{GridName}.grid.xml");
        [XmlElement("Grid")]
        public string GridName { get; set; }
        [XmlElement]
        public List<GridColumnVisible> ColumnVisible { get; set; }

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
            using(var file = File.Open(Path(view.GridName), FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(file, view);
            }
        }
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
    }

    [XmlRoot]
    public class GridColumnVisible
    {
        [XmlElement]
        public string ColName { get; set; }
        [XmlElement]
        public bool Visible { get; set; }
    }
}
