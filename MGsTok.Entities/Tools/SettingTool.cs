using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MGsTok.Entities.Tools
{
    public class SettingTool
    {
        FileIniDataParser parser = new FileIniDataParser();
        private IniData data;
        private string dosyaAdi = "Setting.ini";
        public SettingTool()
        {
            if (System.IO.File.Exists(Application.StartupPath+"\\"+dosyaAdi)==true)
            {
               data= parser.ReadFile(dosyaAdi);
            }
            else
            {

                System.IO.File.Exists(Application.StartupPath + "\\" + dosyaAdi);
                data = parser.ReadFile(dosyaAdi);
            }
        }
       
        public void AyarDegistir(string section,string key,string value)
        {
            if (data!=null)
            {
                if (data.Sections.Count(c => c.SectionName == section) == 0)
                {
                    data.Sections.AddSection(section);
                    data[section].AddKey(key);
                }
                else
                {
                    data[section].AddKey(key);
                }
                data[section][key] = value;

            }
        }
        public string AyarOku(string section, string key)
        {
            return data[section][key];

        }
        public void Save()
        {
            parser.WriteFile(dosyaAdi,data);
        }
    }
}
