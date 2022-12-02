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

        const int CPS_MAX_VALUE = 30;
        const int CPS_MIN_VALUE = 10;

        public bool canSetKey = false;

        public Form1()
        {
            InitializeComponent();
            SetConsoleShow();
            SetStateLabel(false);
            ValueCpsMaxLabel.Text = Program.cpsMax.ToString();
            ValueCpsMinLabel.Text = Program.cpsMin.ToString();
            trackBar_CpsMax.Maximum = CPS_MAX_VALUE;
            trackBar_CpsMin.Maximum = CPS_MAX_VALUE;
            trackBar_CpsMax.Minimum = Program.cpsMin;
            trackBar_CpsMin.Minimum = CPS_MIN_VALUE;

            trackBar_CpsMax.Value = Program.cpsMax;
            trackBar_CpsMin.Value = Program.cpsMin;

            EnableKeyButton.Text = Program.EnableKey.ToString();

            comboBoxTheme.Items.Add("Gray");
            comboBoxTheme.Items.Add("Dark");
            comboBoxTheme.Items.Add("Light");
            comboBoxTheme.SelectedIndex = 0;

            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.Items.Add("Français");
            comboBoxLanguage.SelectedIndex = 0;
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
                StateLabel.Text = "State : Enable";
                StateLabel.BackColor = Color.LightGreen;
            }
            else
            {
                StateLabel.Text = "State : Disable";
                StateLabel.BackColor = Color.LightSalmon;
            }
        }

        private void trackBar_CpsMin_Scroll(object sender, EventArgs e)
        {
            setCpsMinValue(trackBar_CpsMin.Value);
        }

        private void trackBar_CpsMax_Scroll(object sender, EventArgs e)
        {
            setCpsMaxValue(trackBar_CpsMax.Value);
        }

        private void setCpsMaxValue(int value)
        {
            if (value <= trackBar_CpsMax.Value)
            {
                value = trackBar_CpsMax.Value;
            }

            ValueCpsMaxLabel.Text = value.ToString();
            Program.SetCpsMax(value);
        }

        private void setCpsMinValue(int value)
        {
            if (value <= trackBar_CpsMin.Value)
            {
                value = trackBar_CpsMin.Value;
            }

            if (value >= Program.cpsMax)
            {
                setCpsMaxValue(value);
            }

            trackBar_CpsMax.Minimum = Program.cpsMin;
            ValueCpsMinLabel.Text = value.ToString();
            Program.SetCpsMin(value);
        }

        private void EnableKeyButton_Click(object sender, EventArgs e)
        {
            EnableKeyButton.Text = "...";
            canSetKey = true;
        }

        public void RefreshButton()
        {
            EnableKeyButton.Text = Program.EnableKey.ToString();
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comboBoxTheme.SelectedItem.ToString();

            if (value == "Gray")
            {
                BackColor = Color.Gray;

                EnableKeyLabel.ForeColor = Color.Black;
                ThemeLabel.ForeColor = Color.Black;
                MaxLabel.ForeColor = Color.Black;
                MinLabel.ForeColor = Color.Black;
                ValueCpsMaxLabel.ForeColor = Color.Black;
                ValueCpsMinLabel.ForeColor = Color.Black;
                LanguageLabel.ForeColor = Color.Black;

                Console.WriteLine("change theme to Gray");
            } else if (value == "Dark")
            {
                BackColor = Color.Black;

                EnableKeyLabel.ForeColor = Color.White;
                ThemeLabel.ForeColor = Color.White;
                MaxLabel.ForeColor = Color.White;
                MinLabel.ForeColor = Color.White;
                ValueCpsMaxLabel.ForeColor = Color.White;
                ValueCpsMinLabel.ForeColor = Color.White;
                LanguageLabel.ForeColor = Color.White;

                Console.WriteLine("change theme to Dark");
            } else if (value == "Light")
            {
                BackColor = Color.White;

                EnableKeyLabel.ForeColor = Color.Black;
                ThemeLabel.ForeColor = Color.Black;
                MaxLabel.ForeColor = Color.Black;
                MinLabel.ForeColor = Color.Black;
                ValueCpsMaxLabel.ForeColor = Color.Black;
                ValueCpsMinLabel.ForeColor = Color.Black;
                LanguageLabel.ForeColor = Color.Black;

                Console.WriteLine("change theme to Light");
            }
        }
    }
}