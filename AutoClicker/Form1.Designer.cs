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
            this.stateLabel = new System.Windows.Forms.Label();
            this.trackBar_CpsMin = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CpsMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stateLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateLabel.Location = new System.Drawing.Point(12, 19);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(51, 25);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "State";
            // 
            // trackBar_CpsMin
            // 
            this.trackBar_CpsMin.Location = new System.Drawing.Point(159, 58);
            this.trackBar_CpsMin.Name = "trackBar_CpsMin";
            this.trackBar_CpsMin.Size = new System.Drawing.Size(246, 45);
            this.trackBar_CpsMin.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(159, 95);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(246, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(417, 210);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar_CpsMin);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.consoleButton);
            this.Name = "Form1";
            this.Text = "A-l\'aise-Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CpsMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button consoleButton;
        private Label stateLabel;
        private TrackBar trackBar_CpsMin;
        private TrackBar trackBar1;
    }
}