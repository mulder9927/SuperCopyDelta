namespace SuperCopyDelta
{
    partial class MainForm
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
            btnBrowseSource = new Button();
            btnBrowseDestination = new Button();
            btnStartCopy = new Button();
            btnSettings = new Button();
            txtSource = new TextBox();
            txtDestination = new TextBox();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // btnBrowseSource
            // 
            btnBrowseSource.Location = new Point(101, 128);
            btnBrowseSource.Name = "btnBrowseSource";
            btnBrowseSource.Size = new Size(121, 76);
            btnBrowseSource.TabIndex = 0;
            btnBrowseSource.Text = "Source Folder";
            btnBrowseSource.UseVisualStyleBackColor = true;
            btnBrowseSource.Click += BtnBrowseSource_Click;
            // 
            // btnBrowseDestination
            // 
            btnBrowseDestination.Location = new Point(666, 55);
            btnBrowseDestination.Name = "btnBrowseDestination";
            btnBrowseDestination.Size = new Size(121, 76);
            btnBrowseDestination.TabIndex = 1;
            btnBrowseDestination.Text = "Destination folder";
            btnBrowseDestination.UseVisualStyleBackColor = true;
            btnBrowseDestination.Click += BtnBrowseDestination_Click;
            // 
            // btnStartCopy
            // 
            btnStartCopy.Location = new Point(434, 335);
            btnStartCopy.Name = "btnStartCopy";
            btnStartCopy.Size = new Size(134, 48);
            btnStartCopy.TabIndex = 2;
            btnStartCopy.Text = "Start Copy";
            btnStartCopy.UseVisualStyleBackColor = true;
            btnStartCopy.Click += BtnStartCopy_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(12, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 23);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += BtnSettings_Click;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(64, 210);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(202, 23);
            txtSource.TabIndex = 4;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(620, 137);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(216, 23);
            txtDestination.TabIndex = 5;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(434, 558);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(143, 23);
            txtLog.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.A_semi_realistic_cartoon_style_image_showing_files;
            ClientSize = new Size(1021, 880);
            Controls.Add(txtLog);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            Controls.Add(btnSettings);
            Controls.Add(btnStartCopy);
            Controls.Add(btnBrowseDestination);
            Controls.Add(btnBrowseSource);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseSource;
        private Button btnBrowseDestination;
        private Button btnStartCopy;
        private Button btnSettings;
        private TextBox txtSource;
        private TextBox txtDestination;
        private TextBox txtLog;
    }
}
