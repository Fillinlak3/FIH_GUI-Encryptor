using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FIH_GUI_Encryptor
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
            #if DEBUG
            //ConsoleLog.consoleHandle = ConsoleLog.GetConsoleWindow();
            #else
            ConsoleLog.consoleHandle = IntPtr.Zero;
            #endif
            ConsoleLog.WriteLine("FIH_GUI", "<*> Debugging Console Active <*>");
            Application.Run(new Login());
        }
    }
}
