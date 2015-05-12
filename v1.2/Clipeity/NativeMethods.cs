using System;
using System.Runtime.InteropServices;

namespace Clipeity
{
    internal class NativeMethods
    {
        // ReSharper disable once InconsistentNaming
        public const int HWND_BROADCAST = 0xffff;

        // ReSharper disable once InconsistentNaming
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}