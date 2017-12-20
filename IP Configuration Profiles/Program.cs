using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Configuration_Profiles
{
    static class Program
    {
        private static readonly Mutex Mutex = new Mutex(false, "e1a1edfa-7382-41e5-ab56-9b0841ed2071"); // application identifier

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Mutex.WaitOne(TimeSpan.FromSeconds(0), false))
            {
                // another instance is already running
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
