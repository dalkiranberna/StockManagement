using StokTakip.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    static class Program
    {
        public static SQLHelper SqlHelper = new SQLHelper(); public static BrandRepo BrandRepo = new BrandRepo();
        public static PhoneRepo PhoneRepo = new PhoneRepo();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Setting.GetLastLanguage(); 
            Application.Run(new Form1());
        }
    }
}
