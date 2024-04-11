using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FIH_GUI_Encryptor
{
    static class Program
    {
        public static AuthClass.Authentificator AuthentificatorInstance;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            #if DEBUG
            ConsoleLog.consoleHandle = ConsoleLog.GetConsoleWindow();
            #else
            ConsoleLog.consoleHandle = IntPtr.Zero;
            #endif
            ConsoleLog.WriteLine("FIH_GUI", "<*> Debugging Console Active <*>");

            AuthentificatorInstance = new AuthClass.Authentificator();
            Application.Run(new Login());
        }
    }
}
