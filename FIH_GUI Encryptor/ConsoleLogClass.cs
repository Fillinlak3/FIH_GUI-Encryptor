using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FIH_GUI_Encryptor
{
    public class ConsoleLog
    {
        private static int numberOfLines = 0;
        public static readonly int SW_HIDE = 0;
        public static readonly int SW_SHOW = 5;
        public static IntPtr consoleHandle = IntPtr.Zero;

        public ConsoleLog() { }

        /// <summary>
        /// Write a message to the console.
        /// This won't affect the number of lines.
        /// </summary>
        /// <param name="WhoSends">From where the message is sent</param>
        /// <param name="values">Message content</param>
        public static void Write(string WhoSends, params object[] values)
        {
            if (consoleHandle == IntPtr.Zero) return;

            Console.Write($"[{DateTime.Now:dd/MM/yy-HH:mm:ss:ff} # ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(WhoSends);
            Console.ResetColor();
            Console.Write($"] info: ");
            foreach (var val in values)
                Console.Write(val);

            // Resume to the last message written on the console.
            Console.CursorTop = numberOfLines;
        }

        /// <summary>
        /// Write a message to the console.
        /// This will affect the number of lines by incrementing.
        /// </summary>
        /// <param name="WhoSends">From where the message is sent</param>
        /// <param name="values">Message content</param>
        public static void WriteLine(string WhoSends = "", params object[] values)
        {
            if (consoleHandle == IntPtr.Zero) return;

            Console.CursorLeft = 0;
            Console.Write($"[{DateTime.Now:dd/MM/yy-HH:mm:ss:ff} # ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(WhoSends);
            Console.ResetColor();
            Console.Write($"] info: ");
            foreach (var val in values)
                Console.Write(val);
            Console.WriteLine();

            numberOfLines++;
            // Resume to the last message written on the console.
            Console.CursorTop = numberOfLines;
        }
        public static void WriteLine()
        {
            if (consoleHandle == IntPtr.Zero) return;

            Console.WriteLine();

            numberOfLines++;
            // Resume to the last message written on the console.
            Console.CursorTop = numberOfLines;
        }

        /// <summary>
        /// Rewrite a specified line.
        /// WhichLine can be Negative|0|Positive. 
        /// Negative: Start from the current line and go up one by one until WhichLine reached. Should not go over the first console line.
        /// 0: Current line.
        /// Positive: Start form the current line and go down one by one until WhichLine reached. Should not go over the last console line.
        /// </summary>
        /// <param name="WhichLine">This can be Negative|0|Positive.</param>
        /// <param name="WhoSends">From where the message is sent</param>
        /// <param name="values">Message content</param>
        /// <exception cref="ArgumentException">If WhichLine is greater than number of lines in each ways (Positive/Negative).</exception>
        public static void RewriteOnLine(int WhichLine = 0, string WhoSends = "", params object[] values)
        {
            if (consoleHandle == IntPtr.Zero) return;

            int currentTop = Console.CursorTop;

            if (WhichLine < 0)
            {
                // If negative, adjust to a positive index
                WhichLine = Math.Max(0, currentTop + WhichLine);
            }
            else if (WhichLine > numberOfLines)
            {
                // If positive, limit to the number of lines written
                WhichLine = numberOfLines;
            }

            // Move the cursor to the specified line
            Console.CursorTop = WhichLine;
            Console.CursorLeft = 0;

            // Rewrite the line
            Console.Write(new string(' ', Console.WindowWidth));
            Console.CursorLeft = 0;
            Console.Write($"[{DateTime.Now:dd/MM/yy-HH:mm:ss:ff} # ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(WhoSends);
            Console.ResetColor();
            Console.Write($"] info: ");
            foreach (var val in values)
                Console.Write(val);

            // Restore the cursor to the original position
            Console.CursorTop = currentTop;
        }

        public static void ShowConsole(bool restore)
        {
            if (consoleHandle == IntPtr.Zero) return;
        
            int mode = restore ? SW_SHOW : SW_HIDE;
            ShowWindow(consoleHandle, mode);
        }

        #region DLL IMPORTS
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        #endregion
    }
}
