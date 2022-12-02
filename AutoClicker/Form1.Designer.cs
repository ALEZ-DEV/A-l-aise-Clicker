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
            this.consoleButton.Location = new System.Drawing.Point(17, 292);
            this.consoleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.Size = new System.Drawing.Size(164, 38);
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
            this.StateLabel.Location = new System.Drawing.Point(17, 32);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(73, 36);
            this.StateLabel.TabIndex = 1;
            this.StateLabel.Text = "State";
            // 
            // trackBar_CpsMax
            // 
            this.trackBar_CpsMax.Location = new System.Drawing.Point(441, 57);
            this.trackBar_CpsMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_CpsMax.Maximum = 30;
            this.trackBar_CpsMax.Minimum = 10;
            this.trackBar_CpsMax.Name = "trackBar_CpsMax";
            this.trackBar_CpsMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_CpsMax.Size = new System.Drawing.Size(69, 228);
            this.trackBar_CpsMax.TabIndex = 2;
            this.trackBar_CpsMax.Value = 10;
            this.trackBar_CpsMax.Scroll += new System.EventHandler(this.trackBar_CpsMax_Scroll);
            // 
            // trackBar_CpsMin
            // 
            this.trackBar_CpsMin.Location = new System.Drawing.Point(514, 57);
            this.trackBar_CpsMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_CpsMin.Maximum = 30;
            this.trackBar_CpsMin.Minimum = 10;
            this.trackBar_CpsMin.Name = "trackBar_CpsMin";
            this.trackBar_CpsMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_CpsMin.Size = new System.Drawing.Size(69, 228);
            this.trackBar_CpsMin.TabIndex = 3;
            this.trackBar_CpsMin.Value = 10;
            this.trackBar_CpsMin.Scroll += new System.EventHandler(this.trackBar_CpsMin_Scroll);
            // 
            // ValueCpsMaxLabel
            // 
            this.ValueCpsMaxLabel.AutoSize = true;
            this.ValueCpsMaxLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueCpsMaxLabel.Location = new System.Drawing.Point(441, 290);
            this.ValueCpsMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueCpsMaxLabel.Name = "ValueCpsMaxLabel";
            this.ValueCpsMaxLabel.Size = new System.Drawing.Size(43, 36);
            this.ValueCpsMaxLabel.TabIndex = 4;
            this.ValueCpsMaxLabel.Text = "00";
            // 
            // ValueCpsMinLabel
            // 
            this.ValueCpsMinLabel.AutoSize = true;
            this.ValueCpsMinLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueCpsMinLabel.Location = new System.Drawing.Point(514, 288);
            this.ValueCpsMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueCpsMinLabel.Name = "ValueCpsMinLabel";
            this.ValueCpsMinLabel.Size = new System.Drawing.Size(43, 36);
            this.ValueCpsMinLabel.TabIndex = 5;
            this.ValueCpsMinLabel.Text = "00";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxLabel.Location = new System.Drawing.Point(423, 15);
            this.MaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(63, 36);
            this.MaxLabel.TabIndex = 6;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinLabel.Location = new System.Drawing.Point(496, 15);
            this.MinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(59, 36);
            this.MinLabel.TabIndex = 7;
            this.MinLabel.Text = "Min";
            // 
            // EnableKeyLabel
            // 
            this.EnableKeyLabel.AutoSize = true;
            this.EnableKeyLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnableKeyLabel.Location = new System.Drawing.Point(17, 97);
            this.EnableKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnableKeyLabel.Name = "EnableKeyLabel";
            this.EnableKeyLabel.Size = new System.Drawing.Size(140, 36);
            this.EnableKeyLabel.TabIndex = 8;
            this.EnableKeyLabel.Text = "Enable Key";
            // 
            // EnableKeyButton
            // 
            this.EnableKeyButton.Location = new System.Drawing.Point(164, 100);
            this.EnableKeyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableKeyButton.Name = "EnableKeyButton";
            this.EnableKeyButton.Size = new System.Drawing.Size(107, 38);
            this.EnableKeyButton.TabIndex = 9;
            this.EnableKeyButton.Text = "button1";
            this.EnableKeyButton.UseVisualStyleBackColor = true;
            this.EnableKeyButton.Click += new System.EventHandler(this.EnableKeyButton_Click);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThemeLabel.Location = new System.Drawing.Point(17, 162);
            this.ThemeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(94, 36);
            this.ThemeLabel.TabIndex = 10;
            this.ThemeLabel.Text = "Theme";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Gray",
            "Dark",
            "Light"});
            this.comboBoxTheme.Location = new System.Drawing.Point(119, 167);
            this.comboBoxTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(171, 33);
            this.comboBoxTheme.TabIndex = 11;
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageLabel.Location = new System.Drawing.Point(17, 227);
            this.LanguageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(127, 36);
            this.LanguageLabel.TabIndex = 12;
            this.LanguageLabel.Text = "Language";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Français"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(164, 232);
            this.comboBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(171, 33);
            this.comboBoxLanguage.TabIndex = 13;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(596, 350);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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