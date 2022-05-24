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
using System.Runtime.InteropServices;
using System.Windows.Controls;

namespace RetroTransferUI
{
    public partial class Dashboard : Form
    {
        private readonly RaspberryPi raspberryPi = RaspberryPi.Instance;
        private readonly ConfigurationForm configForm = new ConfigurationForm();
        private readonly ConfigurationConnection configConnection = new ConfigurationConnection();
        private readonly PlatformExtensions platformExtensions = PlatformExtensions.Instance;

        public Dashboard()
        {
            InitializeComponent();

            configForm.RaiseConfigEvent += RaspberryPiConfig_ConfigEvent;
            
            CheckConfigFileForRaspberryPi();
            CheckPlatformFileForPlatformExtensions();

            ConfigureHeaderText();
            ShowIntroMessage();
        }


        private void ShowIntroMessage()
        {
            if (!raspberryPi.IsInitialized)
            {
                configForm.ShowDialog();
            }
        }

        private void CheckPlatformFileForPlatformExtensions()
        {
            if (platformExtensions.PlatformsFileExists())
            {
                platformExtensions.InitPlatformExtensions();
            }
        }

        private void CheckConfigFileForRaspberryPi()
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

        private void ConfigureHeaderText()
        {
            if (!raspberryPi.IsInitialized)
            {
                DisableControls();
                configButton.Text = "RASPBERRY PI NOT CONFIGURED";

            }
            else
            {
                EnableControls();
                configButton.Text = $"{raspberryPi.Username}@{raspberryPi.IpAddress}";
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

        private void DisableControls()
        {
            romDisplayContainer.Enabled = false;
            sendButton.Enabled = false;
        }
        private void EnableControls()
        {
            romDisplayContainer.Enabled = true;
            sendButton.Enabled = true;
        }

        private void headerText_Click(object sender, EventArgs e)
        {

        }

        private void raspberryPiConfigTitleText_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Border border = new Border();
            border.CornerRadius = new System.Windows.CornerRadius(15);



        }
    }
}
