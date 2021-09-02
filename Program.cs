using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationofNCinBC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var culture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            // this may fail sometimes: (see Drachenkatze's comment below)
            // var culture = new CultureInfo("en-US");

            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;

            //Culture for UI in any thread
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            //Culture for current thread (STA)
            //no need for: Application.CurrentCulture = culture;

            //Thread.CurrentThread.CurrentCulture == Application.CurrentCulture
            //no need for: Thread.CurrentThread.CurrentCulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
