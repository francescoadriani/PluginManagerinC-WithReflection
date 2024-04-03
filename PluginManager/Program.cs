using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;

namespace PluginManager
{

    class BeepSample
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Beep(uint dwFreq, uint dwDuration);

        static void Main()
        {
            Console.WriteLine("Testing PC speaker...");
            for (uint i = 100; i <= 20000; i++)
            {
                Beep(i, 5);
            }
            Console.WriteLine("Testing complete.");
        }
    }

    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());
        //}



    }



}
