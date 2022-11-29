using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class Mouse
    {

        //mouse detection
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern short GetAsyncKeyState(int nVirtKey);
        public const int VK_LBUTTON = 0x01;
        private const int WH_MOUSE_LL = 14;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;

        private static IntPtr _mouseHookID = IntPtr.Zero;

        private delegate IntPtr LowLevelMouseProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static LowLevelMouseProc _mouseProc = mouseHookCallback;

        public void StartHook()
        {
            _mouseHookID = SetHook(_mouseProc);
        }

        public void StopHook()
        {
            UnhookWindowsHookEx(_mouseHookID);
        }

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr mouseHookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            //on down
            if (nCode >= 0 && wParam == (IntPtr)WM_LBUTTONDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Console.WriteLine((Keys)vkCode);
                Program.SetCanClick();
            }
            //on up
            else if (nCode >= 0 && wParam == (IntPtr)WM_LBUTTONUP)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Console.WriteLine((Keys)vkCode);
                Program.SetCanClick();
            }
            return CallNextHookEx(_mouseHookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

    }
}
