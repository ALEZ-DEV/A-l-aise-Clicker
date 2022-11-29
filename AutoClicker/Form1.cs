using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public Form1()
        {
            InitializeComponent();
            SetConsoleShow();
            SetStateLabel(false);
        }

        bool isShow = true;

        private void Console_SetShow(object sender, EventArgs e)
        {
            SetConsoleShow();
        }

        public void SetConsoleShow()
        {
            var handle = GetConsoleWindow();

            if (isShow)
            {
                ShowWindow(handle, SW_HIDE);
                consoleButton.Text = "Show Console";
                isShow = !isShow;
            }
            else
            {
                ShowWindow(handle, SW_SHOW);
                consoleButton.Text = "Hide Console";
                isShow = !isShow;
            }
        }

        public void SetStateLabel(bool state)
        {
            if (state)
            {
                stateLabel.Text = "State : Enable";
                stateLabel.BackColor = Color.LightGreen;
            }
            else
            {
                stateLabel.Text = "State : Disable";
                stateLabel.BackColor = Color.LightSalmon;
            }
        }
    }
}