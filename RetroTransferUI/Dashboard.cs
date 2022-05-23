using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RetroTransferLibrary;
using System.IO;

namespace RetroTransferUI
{
    public partial class Dashboard : Form
    {
        private RaspberryPi raspberryPi = RaspberryPi.Instance;
        private ConfigurationForm configForm = new ConfigurationForm();
        private ConfigurationConnection configConnection = new ConfigurationConnection();

        public Dashboard()
        {
            InitializeComponent();
            CheckConfigForRaspberryPi();
            ConfigureHeaderText();
            configForm.RaiseConfigEvent += RaspberryPiConfig_ConfigEvent;
        }

        private void CheckConfigForRaspberryPi()
        {
            if (configConnection.ConfigFileExists())
            {
                configConnection.GetRaspberryPi();
                configForm.UpdateConfigurationFields();
            }
        }

        private void RaspberryPiConfig_ConfigEvent(object sender, EventArgs e)
        {
            ConfigureHeaderText();
            romDisplayContainer.Controls.Clear();
        }

        // Note to self: Is it safer to include the Raspberry Pi as the parameter?
        private void ConfigureHeaderText()
        {
            if (!raspberryPi.IsInitialized)
            {
                // Show alert saying that the Raspberry Pi hasn't been configured properly

            }
            else
            {
                headerText.Text = $"Sending to {raspberryPi.Username}@{raspberryPi.IpAddress}";
            }
        }

        private void romDropCollector_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void romDropCollector_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string filePath in filePaths)
            {
                romDisplayContainer.Controls.Add(new RomDisplay(filePath));
            }
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            List<Rom> romsToSend = new List<Rom>();
            foreach (RomDisplay romDisplay in romDisplayContainer.Controls)
            {
                romsToSend.Add(romDisplay.CurrentRom);
            }

            RomUploadForm romUploadForm = new RomUploadForm(romsToSend);
            romUploadForm.ShowDialog();

            romDisplayContainer.Controls.Clear();
        }


        private void ConfigButton_Click(object sender, EventArgs e)
        {
            configForm.ShowDialog();
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (raspberryPi.IsInitialized)
            {
                configConnection.SaveRaspberryPi();
            }
        }

        private void RomDisplayContainer_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string filePath in filePaths)
            {
                romDisplayContainer.Controls.Add(new RomDisplay(filePath));
            }
        }

        private void RomDisplayContainer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
