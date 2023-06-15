namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            labelGreen = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            labelYellow = new Label();
            labelRed = new Label();
            SuspendLayout();
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(488, 184);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(38, 15);
            labelGreen.TabIndex = 0;
            labelGreen.Text = "label1";
            labelGreen.Click += timerCountdown_Tick;
            // 
            // labelYellow
            // 
            labelYellow.AutoSize = true;
            labelYellow.Location = new Point(498, 264);
            labelYellow.Name = "labelYellow";
            labelYellow.Size = new Size(38, 15);
            labelYellow.TabIndex = 1;
            labelYellow.Text = "label1";
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(503, 325);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(38, 15);
            labelRed.TabIndex = 2;
            labelRed.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRed);
            Controls.Add(labelYellow);
            Controls.Add(labelGreen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGreen;
        private System.Windows.Forms.Timer timerCountdown;
        private Label labelYellow;
        private Label labelRed;
    }
}