using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void RomUploadThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RomUploadThread_DoWork(object sender, DoWorkEventArgs e)
        {
            SendRom();
        }

        public void SendRom()
        {
            ScpClient scp = new ScpClient(raspberryPi.IpAddress, raspberryPi.Username, raspberryPi.Password);
            scp.Connect();

            foreach (Rom rom in roms)
            {
                using (Stream localFile = File.OpenRead(rom.LocalPath))
                {
                    string destinationPath = $"{raspberryPi.RetroPieDirectory}/{rom.DestinationPath}";
                    scp.Upload(localFile, destinationPath);
                }
            }
            scp.Disconnect();
        }














        private void RomUploadForm_Load(object sender, EventArgs e)
        {

        }
    }
}
