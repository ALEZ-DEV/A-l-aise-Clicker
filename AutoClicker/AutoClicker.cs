using Desktop.Robot;
using Desktop.Robot.Clicks;
using Desktop.Robot.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class AutoClicker
    {

        int cpsMin = 0;
        int cpsMax = 0;
        Robot robot;
        public bool exit = false;
        public bool canClick = false;
        public int threadId { get; set; }
        public bool isClicking = false;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public AutoClicker(int cpsMin, int cpsMax)
        {
            this.cpsMin = cpsMin;
            this.cpsMax = cpsMax;
            Start();
        }

        public Thread Start()
        {
            Thread t = new Thread(click);
            threadId = t.ManagedThreadId;
            t.Start();
            return t;
        }

        public void click()
        {
            Random r = new Random();
            int trueCps;

            while (!exit)
            {
                if (canClick)
                {
                    trueCps = r.Next(cpsMin, cpsMax);

                    wait(1000 / trueCps);
                    //Call the imported function with the cursor's current position
                    uint X = (uint)Cursor.Position.X;
                    uint Y = (uint)Cursor.Position.Y;
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
            }
        }

        public void wait(int milliSeconds)
        {
            Stopwatch sw = Stopwatch.StartNew();

            while (sw.Elapsed.TotalMilliseconds < milliSeconds) { }

            sw.Stop();
        }

        public Thread GetCurrentThread()
        {
            return Thread.CurrentThread;
        }
    }
}
