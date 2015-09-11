using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConfigurationManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string setting1 = ConfigurationManager.AppSettings["setting1"].ToString();
            string setting2 = ConfigurationManager.AppSettings["setting2"].ToString();

            Console.WriteLine("setting1; {0}, setting2: {1} ",setting1,setting2);

            string key = "setting1";
            string value = "setting3";
            AddUpdateAppSettings(key, value);
        }
        static void AddUpdateAppSettings(string key,string value )
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = ConfigurationManager.AppSettings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key] = value;
                }
                configFile.Save();
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                
             }catch(ConfigurationErrorsException)
            {
                Console.WriteLine("Error Writing app settings");
            }
        }
    }
}
