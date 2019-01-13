using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace StokTakip
{
    enum Language
    {
        tr,
        en
    }
    class Setting
    {
        public static void ChangeLanguage(Language lang)
        {
            CultureInfo.CurrentCulture = new CultureInfo(lang.ToString()); 
            CultureInfo.CurrentUICulture = new CultureInfo(lang.ToString());

            JavaScriptSerializer jss = new JavaScriptSerializer();
            var json = jss.Serialize(lang);
            File.WriteAllText("languageSettings.json", json);
        }

        public static void GetLastLanguage()
        {
            Language lang = Language.tr;
            if (File.Exists("languageSettings.json"))
            {
                var settingContent = File.ReadAllText("languageSettings.json");
                JavaScriptSerializer jss = new JavaScriptSerializer();
                lang = jss.Deserialize<Language>(settingContent);
            }

            CultureInfo.CurrentCulture = new CultureInfo(lang.ToString());
            CultureInfo.CurrentUICulture = new CultureInfo(lang.ToString());
        }
    }
}
