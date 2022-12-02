namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleButton = new System.Windows.Forms.Button();
            this.StateLabel = new System.Windows.Forms.Label();
            this.trackBar_CpsMax = new System.Windows.Forms.TrackBar();
            this.trackBar_CpsMin = new System.Windows.Forms.TrackBar();
            this.ValueCpsMaxLabel = new System.Windows.Forms.Label();
            this.ValueCpsMinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.EnableKeyLabel = new System.Windows.Forms.Label();
            this.EnableKeyButton = new System.Windows.Forms.Button();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CpsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CpsMin)).BeginInit();
            this.SuspendLayout();
            // 
            // consoleButton
            // 
            this.consoleButton.Location = new System.Drawing.Point(12, 175);
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.Size = new System.Drawing.Size(115, 23);
            this.consoleButton.TabIndex = 0;
            this.consoleButton.Text = "Show Console";
            this.consoleButton.UseVisualStyleBackColor = true;
            this.consoleButton.Click += new System.EventHandler(this.Console_SetShow);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StateLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateLabel.Location = new System.Drawing.Point(12, 19);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(51, 25);
            this.StateLabel.TabIndex = 1;
            this.StateLabel.Text = "State";
            // 
            // trackBar_CpsMax
            // 
            this.trackBar_CpsMax.Location = new System.Drawing.Point(309, 34);
            this.trackBar_CpsMax.Maximum = 30;
            this.trackBar_CpsMax.Minimum = 10;
            this.trackBar_CpsMax.Name = "trackBar_CpsMax";
            this.trackBar_CpsMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_CpsMax.Size = new System.Drawing.Size(45, 137);
            this.trackBar_CpsMax.TabIndex = 2;
            this.trackBar_CpsMax.Value = 10;
            this.trackBar_CpsMax.Scroll += new System.EventHandler(this.trackBar_CpsMax_Scroll);
            // 
            // trackBar_CpsMin
            // 
            this.trackBar_CpsMin.Location = new System.Drawing.Point(360, 34);
            this.trackBar_CpsMin.Maximum = 30;
            this.trackBar_CpsMin.Minimum = 10;
            this.trackBar_CpsMin.Name = "trackBar_CpsMin";
            this.trackBar_CpsMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_CpsMin.Size = new System.Drawing.Size(45, 137);
            this.trackBar_CpsMin.TabIndex = 3;
            this.trackBar_CpsMin.Value = 10;
            this.trackBar_CpsMin.Scroll += new System.EventHandler(this.trackBar_CpsMin_Scroll);
            // 
            // ValueCpsMaxLabel
            // 
            this.ValueCpsMaxLabel.AutoSize = true;
            this.ValueCpsMaxLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueCpsMaxLabel.Location = new System.Drawing.Point(309, 174);
            this.ValueCpsMaxLabel.Name = "ValueCpsMaxLabel";
            this.ValueCpsMaxLabel.Size = new System.Drawing.Size(32, 25);
            this.ValueCpsMaxLabel.TabIndex = 4;
            this.ValueCpsMaxLabel.Text = "00";
            // 
            // ValueCpsMinLabel
            // 
            this.ValueCpsMinLabel.AutoSize = true;
            this.ValueCpsMinLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueCpsMinLabel.Location = new System.Drawing.Point(360, 173);
            this.ValueCpsMinLabel.Name = "ValueCpsMinLabel";
            this.ValueCpsMinLabel.Size = new System.Drawing.Size(32, 25);
            this.ValueCpsMinLabel.TabIndex = 5;
            this.ValueCpsMinLabel.Text = "00";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxLabel.Location = new System.Drawing.Point(296, 9);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(45, 25);
            this.MaxLabel.TabIndex = 6;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinLabel.Location = new System.Drawing.Point(347, 9);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(42, 25);
            this.MinLabel.TabIndex = 7;
            this.MinLabel.Text = "Min";
            // 
            // EnableKeyLabel
            // 
            this.EnableKeyLabel.AutoSize = true;
            this.EnableKeyLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnableKeyLabel.Location = new System.Drawing.Point(12, 58);
            this.EnableKeyLabel.Name = "EnableKeyLabel";
            this.EnableKeyLabel.Size = new System.Drawing.Size(97, 25);
            this.EnableKeyLabel.TabIndex = 8;
            this.EnableKeyLabel.Text = "Enable Key";
            // 
            // EnableKeyButton
            // 
            this.EnableKeyButton.Location = new System.Drawing.Point(115, 60);
            this.EnableKeyButton.Name = "EnableKeyButton";
            this.EnableKeyButton.Size = new System.Drawing.Size(75, 23);
            this.EnableKeyButton.TabIndex = 9;
            this.EnableKeyButton.Text = "button1";
            this.EnableKeyButton.UseVisualStyleBackColor = true;
            this.EnableKeyButton.Click += new System.EventHandler(this.EnableKeyButton_Click);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThemeLabel.Location = new System.Drawing.Point(12, 97);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(65, 25);
            this.ThemeLabel.TabIndex = 10;
            this.ThemeLabel.Text = "Theme";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.Location = new System.Drawing.Point(83, 100);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTheme.TabIndex = 11;
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageLabel.Location = new System.Drawing.Point(12, 136);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(89, 25);
            this.LanguageLabel.TabIndex = 12;
            this.LanguageLabel.Text = "Language";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Gray",
            "Dark",
            "Light"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(115, 139);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLanguage.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(417, 210);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.EnableKeyButton);
            this.Controls.Add(this.EnableKeyLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.ValueCpsMinLabel);
            this.Controls.Add(this.ValueCpsMaxLabel);
            this.Controls.Add(this.trackBar_CpsMin);
            this.Controls.Add(this.trackBar_CpsMax);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.consoleButton);
            this.Name = "Form1";
            this.Text = "A l\'aise Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CpsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CpsMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button consoleButton;
        private Label StateLabel;
        private TrackBar trackBar_CpsMax;
        private TrackBar trackBar_CpsMin;
        private Label ValueCpsMaxLabel;
        private Label ValueCpsMinLabel;
        private Label MaxLabel;
        private Label MinLabel;
        private Label EnableKeyLabel;
        private Button EnableKeyButton;
        private Label ThemeLabel;
        private ComboBox comboBoxTheme;
        private Label LanguageLabel;
        private ComboBox comboBoxLanguage;
    }
}