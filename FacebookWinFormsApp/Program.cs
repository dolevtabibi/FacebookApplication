using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Clipboard.SetText("saardolevdesig1"); /// the current password for our facebook
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormFlowManager formFlowManager = new FormFlowManager();
            formFlowManager.RunApp();
        }
    }
}
