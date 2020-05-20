using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server.Settings
{
    class Main_settings
    {
        public Main_settings()
        {

        }
        public static JObject tet = JObject.Parse(File.ReadAllText("Settings\\settings.json"));
        public static void ifyes()
        {
            if (!Directory.Exists("Settings")) Directory.CreateDirectory("Settings");
            if (!File.Exists("Settings\\settings.json")) File.Create("Settings\\settings.json");
            if (!File.ReadAllText("Settings\\settings.json").Contains("_ignore")) File.WriteAllText("Settings\\settings.json", "{\n\"_ignore\": \"ignore\",\n\"listen_1\": \"false\",\n\"listen_2\": \"false\"\n}");
        }
        public static void SaveSettings()
        {
            using (StreamWriter file = File.CreateText("Settings\\settings.json"))
            tet.WriteTo(new JsonTextWriter(file));
        }
        public static void ChangeSettings(string name, string value)
        {
            ifyes();
            tet[name] = value;
        }
        public static void ResetSettings()
        {
            ifyes();
            Directory.Delete("Settings\\settings.json");
            ifyes();
        }
        public static void AddSettings(string name, string value)
        {
            tet.Add(name,value);
        }
        public static string GetSettings(string name)
        {
            ifyes();
            return tet[name].ToString();
        }
    }
}
