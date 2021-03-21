using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;

namespace AppConfiguration
{
    public class ConfigService
    {
        private static readonly string FullPathConfig = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\config.xml";

        public static bool Save(Configuration config)
        {
            var serializer = new XmlSerializer(typeof(Configuration));

            try
            {
                using (var file = new FileStream(FullPathConfig, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(file, config);
                }

                return true;

            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static Configuration Load()
        {
            CreateFileConfigIfNotExists();

            var config = new Configuration();

            var serializer = new XmlSerializer(typeof(Configuration));

            try
            {
                using (var file = new FileStream(FullPathConfig, FileMode.Open, FileAccess.Read))
                {
                    config = (Configuration)serializer.Deserialize(file);
                }

                return config;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void CreateFileConfigIfNotExists()
        {
            if (!File.Exists(FullPathConfig))
            {
                Save(new Configuration());
            }
        }

    }
}
