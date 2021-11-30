using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Napraviti GUI program koji će odbrojavati vrijeme za neki početno zadani period (npr. 
odbrojavati trajanje ispita) i prikazivati preostalo vrijeme u minutama preko cijelog ekrana. 
Zadnjih 5 minuta brojevi moraju treptati kao upozorenje za skori istek vremena. Opcionalno 
dodati zvučne signale za 5 minuta prije kraja i za istek vremena.

 */

namespace Timer
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
            Application.Run(new Form1());
        }
    }
}
