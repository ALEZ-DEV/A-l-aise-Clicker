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
        public static Mouse mouse;
        public static Keyboard keyboard;
        public static Form1 form;

        public static int cpsMin = 10;
        public static int cpsMax = 14;

        static void Main()
        {
            mouse = new Mouse();
            keyboard = new Keyboard();

            ApplicationConfiguration.Initialize();
            keyboard.StartHook();
            mouse.StartHook();
            form = new Form1();
            Application.Run(form);
            keyboard.StopHook();
            mouse.StopHook();
        }

        public static void SetClicking()
        {
            if (autoClickerThreadId == 0)
            {
                Console.WriteLine("enable");
                autoClicker = new AutoClicker(cpsMin, cpsMax);
                autoClickerThreadId = autoClicker.threadId;
                autoClickerThread = autoClicker.GetCurrentThread();
                form.SetStateLabel(true);
            } 
            else
            {
                Console.WriteLine("disable");
                autoClickerThreadId = 0;
                autoClicker.exit = true;
                form.SetStateLabel(false);
            }

        }

        public static void SetCanClick()
        {
            if (!(autoClickerThreadId == 0))
            {
                autoClicker.canClick = !autoClicker.canClick;
            }
        }

        public static void SetCpsMax(int value)
        {
            cpsMax = value;
        }

        public static void SetCpsMin(int value)
        {
            cpsMin = value;
        }

        public static void SetKey(Keys key)
        {
            EnableKey = key;
        }
    }
}
