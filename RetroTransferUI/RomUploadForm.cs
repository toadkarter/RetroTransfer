using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using RetroTransferLibrary;

namespace RetroTransferUI
{
    public partial class RomUploadForm : Form
    {
        RaspberryPi raspberryPi = RaspberryPi.Instance;
        List<Rom> roms;
        
        public RomUploadForm(List<Rom> roms)
        {
            InitializeComponent();
            this.roms = roms;
            romUploadThread.DoWork += RomUploadThread_DoWork;
            romUploadThread.ProgressChanged += RomUploadThread_ProgressChanged;
            romUploadThread.RunWorkerCompleted += RomUploadThread_RunWorkerCompleted;

            romUploadThread.RunWorkerAsync();
        }

        private void RomUploadThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sendingText.Text = "All Done!";
            returnButton.Enabled = true;
        }

        private void RomUploadThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            sendingText.Text = e.UserState.ToString();
            progressBar.Increment(e.ProgressPercentage);
        }

        private void RomUploadThread_DoWork(object sender, DoWorkEventArgs e)
        {
            SendRom();
        }

        public void SendRom()
        {
            ScpClient scp = new ScpClient(raspberryPi.IpAddress, raspberryPi.Username, raspberryPi.Password);
            scp.Connect();

            int progressBarOffset = 2;
            int romPercentage = (int)Math.Round(1.0 / roms.Count * 100);
            int romPercentageWithOffset = romPercentage - progressBarOffset;

            foreach (Rom rom in roms)
            {
                using (Stream localFile = File.OpenRead(rom.LocalPath))
                {
                    romUploadThread.ReportProgress(progressBarOffset, rom.FileName);

                    string destinationPath = $"{raspberryPi.RetroPieDirectory}/{rom.DestinationPath}";
                    scp.Upload(localFile, destinationPath);
                    
                    romUploadThread.ReportProgress(romPercentageWithOffset, rom.FileName);
                }
            }
            scp.Disconnect();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
