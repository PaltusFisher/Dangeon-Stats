using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUNGEON
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //main constructor
            Game.GameInitiate();
            //run mainWindow
            Application.Run(new MainWindow());
        }
    }
}
