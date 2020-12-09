using AutoMapper;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Dukan.Core.Mapping;
using Products.PL;
using System;
using System.Windows.Forms;

namespace Products
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("VS2010");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            Application.Run(FormMain.GetInstance);
        }
    }
}
