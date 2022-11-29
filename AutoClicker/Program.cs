using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    internal class Program
    {

        static int autoClickerThreadId = 0;
        static Thread autoClickerThread = null;
        static AutoClicker autoClicker;

        public static Keys EnableKey = Keys.F4;

        public static int cpsMin = 13;
        public static int cpsMax = 15;

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            _hookID = SetHook(_proc);
            Application.Run(new Form1());
            UnhookWindowsHookEx(_hookID);
        }

        public static void SetClicking()
        {
            if (autoClickerThreadId == 0)
            {
                Console.WriteLine("enable");
                autoClicker = new AutoClicker(cpsMin, cpsMax);
                autoClickerThreadId = autoClicker.threadId;
                autoClickerThread = autoClicker.GetCurrentThread();
            } 
            else
            {
                Console.WriteLine("disable");
                autoClickerThreadId = 0;
                autoClicker.exit = true;
            }

        }

        //mouse detection
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern short GetAsyncKeyState(int nVirtKey);
        public const int VK_LBUTTON = 0x01;

        private const int WH_KEYBOARD_LL = 13;
        private const int WH_MOUSE_LL = 14;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;

        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Console.WriteLine((Keys)vkCode);
                if ((Keys) vkCode == EnableKey) 
                {
                    SetClicking();
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

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
