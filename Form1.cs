using System;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace SuperCopyDelta
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnBrowseSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnBrowseDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnStartCopy_Click(object sender, EventArgs e)
        {
            string source = txtSource.Text;
            string destination = txtDestination.Text;
            string logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "copy_log.txt");

            if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please select both source and destination folders.");
                return;
            }

            RunRobocopy(source, destination, logFile);
        }

        private void RunRobocopy(string source, string destination, string logFile)
        {
            string arguments = $"/E /COPY:DAT /256 /LOG+:{logFile} /TEE /R:0 /W:0 /V /FP \"{source}\" \"{destination}\"";
            ProcessStartInfo psi = new ProcessStartInfo("robocopy")
            {
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    txtLog.AppendText(output + Environment.NewLine);
                    if (!string.IsNullOrWhiteSpace(error))
                    {
                        txtLog.AppendText("Errors:" + Environment.NewLine + error + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}