using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Aula7Virus
{

    static class Program
    {
        const UInt32 WM_KEYDOWN = 0x0100;
        const int VK_F5 = 0x74;
        // const int VK_R = 0x52;
        // const int VK_A = 0x41;
        // const int VK_F = 0x46;
        // const int VK_E = 0x45;
        // const int VK_L = 0x45;

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [STAThread]
        static void Main()
        {
            while (true)
            {
                Process[] processes = Process.GetProcessesByName("iexplorer");

                foreach (Process proc in processes)
                {
                    PostMessage(proc.MainWindowHandle, WM_KEYDOWN, VK_F5, 0);
                }
                Thread.Sleep(5000);
            }
        }
    }
}
