using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using static Pigeon.PassCode.PassEncoder;

namespace Pigeon.Class
{
    [XmlRoot(ElementName = "Config")]
    public class Config
    {
        #region EMAIL CONFIG
        [XmlElement]
        public string Email
        {
            get;
            set;
        }
        [XmlElement]
        public string Login
        {
            get;
            set;
        }
        protected string pass;
        [XmlElement]
        public string Pass
        {
            get { return pass; }
            set { pass = Encode(value); }
        }
        [XmlElement]
        public string SMTP_Adres
        {
            get;
            set;
        }
        [XmlElement]
        public int SMTP_Port
        {
            get;
            set;
        }
        #endregion

        #region Instancja
        private static Config config = new Config();
        private static string path = "config.xml";
        private static XmlSerializer serializer = new XmlSerializer(typeof(Config));
        private Config()
        {
            
        }
        /// <summary>
        /// Zwraca instancję obiektu Konfiguracji
        /// </summary>
        /// <returns></returns>
        public static Config GetInstance()
        {
            if (File.Exists(path))
            {
                using (TextReader reader = new StreamReader(path))
                {
                    config = (Config)serializer.Deserialize(reader);
                }
            }

            return config;
        }
        #endregion

        /// <summary>
        /// Aktualizuje konfiguracje
        /// </summary>
        public void Update()
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Dispose();
            }

            using(TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, config);
            }
        }

        public string GetPass() => Decode(Decode(pass));
    }
}
