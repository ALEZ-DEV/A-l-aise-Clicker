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

        private Lang language;

        public Form1()
        {
            InitializeComponent();
            language = new Lang("en");
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

            comboBoxTheme.SelectedIndex = 0;

            comboBoxLanguage.SelectedIndex = 0;

            SetLanguage("en");
        }

        public void SetLanguage(string lang)
        {
            language.SetLanguage(lang);

            EnableKeyLabel.Text = language.enableKeyLabel;

            ThemeLabel.Text = language.themeLabel;

            LanguageLabel.Text = language.languageLabel;

            if (isShow)
            {
                consoleButton.Text = language.showConsole;
            }
            else
            {
                consoleButton.Text = language.hideConsole;
            }

            if (state)
            {
                StateLabel.Text = language.stateEnable;
            }
            else
            {
                StateLabel.Text = language.stateDisable;
            }
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
                consoleButton.Text = language.hideConsole;
                isShow = !isShow;
            }
            else
            {
                ShowWindow(handle, SW_SHOW);
                consoleButton.Text = language.showConsole;
                isShow = !isShow;
            }
        }

        bool state;

        public void SetStateLabel(bool state)
        {
            this.state = state;

            if (state)
            {
                StateLabel.Text = language.stateEnable;
                StateLabel.BackColor = Color.LightGreen;
            }
            else
            {
                StateLabel.Text = language.stateDisable;
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

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

            string value = comboBoxLanguage.SelectedItem.ToString();

            if (value == "English")
            {
                SetLanguage("en");
                EnableKeyButton.Location = new Point(164, 100);
            }
            else if (value == "Français")
            {
                SetLanguage("fr");
                EnableKeyButton.Location = new Point(254, 100);
            }
        }
    }
}