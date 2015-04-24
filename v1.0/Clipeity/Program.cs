using System;
using System.Threading;
using System.Windows.Forms;

namespace Clipeity
{
    internal static class Program
    {
        // ReSharper disable once InconsistentNaming
        private static readonly Mutex _mutex = new Mutex(true, "{F2C5A8DC-9EA3-486B-8345-4BD2D0F2CCB9}");

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                // send our Win32 message to make the currently running instance
                // jump on top of all the other windows
                NativeMethods.PostMessage(
                    (IntPtr) NativeMethods.HWND_BROADCAST,
                    NativeMethods.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
        }
    }
}