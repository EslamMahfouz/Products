using DevExpress.DXCore.Controls.LookAndFeel;
using DevExpress.DXCore.Controls.Skins;
using DevExpress.UserSkins;
using Products.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BonusSkins.Register();
            UserLookAndFeel.Default.SkinName = "Metropolis Dark";
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            Application.Run(new FormMain());
        }
    }
}
