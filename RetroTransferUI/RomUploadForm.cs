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
        readonly RaspberryPi raspberryPi = RaspberryPi.Instance;
        readonly List<Rom> roms;
        int progressBarOffset = 2;
        int romPercentageWithOffset; 

        public RomUploadForm(List<Rom> roms)
        {
            this.roms = roms;
            
            InitializeComponent();
            InitializeProgressBarValues();
            InitializeEvents();

            romUploadThread.RunWorkerAsync();
        }

        private void InitializeEvents()
        {
            romUploadThread.DoWork += RomUploadThread_DoWork;
            romUploadThread.ProgressChanged += RomUploadThread_ProgressChanged;
            romUploadThread.RunWorkerCompleted += RomUploadThread_RunWorkerCompleted;
        }

        private void InitializeProgressBarValues()
        {
            int romPercentage = (int)Math.Round(1.0 / roms.Count * 100);
            progressBarOffset = 2;
            romPercentageWithOffset = romPercentage - progressBarOffset;
        }

        private void RomUploadThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sendingText.Text = "All Done!";
            returnButton.Visible = true;
            returnButton.Enabled = true;
        }

        private void RomUploadThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            sendingText.Text = e.UserState.ToString();
            progressBar.Increment(e.ProgressPercentage);
        }

        private void RomUploadThread_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectAndUploadRoms();
        }

        public void ConnectAndUploadRoms()
        {
            ScpClient scp = new ScpClient(raspberryPi.IpAddress, raspberryPi.Username, raspberryPi.Password);
            scp.Connect();
            UploadAllRoms(scp);
            scp.Disconnect();
        }

        private void UploadAllRoms(ScpClient scp)
        {
            foreach (Rom rom in roms)
            {
                UploadRom(scp, rom);
            }
        }

        private void UploadRom(ScpClient scp, Rom rom)
        {
            using (Stream localFile = File.OpenRead(rom.LocalPath))
            {
                romUploadThread.ReportProgress(progressBarOffset, rom.FileName);

                string destinationPath = $"{raspberryPi.RetroPieDirectory}/{rom.DestinationPath}";
                scp.Upload(localFile, destinationPath);

                romUploadThread.ReportProgress(romPercentageWithOffset, rom.FileName);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
