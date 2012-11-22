using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using nAssembla.TestHarness.Properties;

namespace nAssembla.TestHarness
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var canContinue = !string.IsNullOrEmpty(Settings.Default.ApiKey) && !string.IsNullOrEmpty(Settings.Default.ApiSecret);

            if (!canContinue)
            {
                var f1 = new ApiKeyAuthenticate();
                canContinue = f1.ShowDialog() == DialogResult.OK;
            }


            if (canContinue)
            {
                nAssembla.Configuration.ApiKey = Settings.Default.ApiKey;
                nAssembla.Configuration.ApiSecret = Settings.Default.ApiSecret;
                Application.Run(new MainForm()); 
            }
            else
                Application.Exit();

           

            //Awaiting resolution of: https://www.assembla.com/spaces/AssemblaSupport/support/tickets/5125-api---pin-code-authorisation#/activity/ticket:

            //nAssembla.Configuration.ClientId = "";
            //nAssembla.Configuration.ClientSecret = "";
            
            //var f1 = new PINAuthenticate();
            //DialogResult dr = f1.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
                
            //}
            //else
            //{
            //    Application.Exit();
            //} 
        }
    }
}
