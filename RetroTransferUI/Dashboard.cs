using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RetroTransferLibrary;
using System.Windows.Controls;
using System.Drawing;
using System.Drawing.Drawing2D;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace RetroTransferUI
{
    public partial class Dashboard : MaterialForm
    {
        private readonly RaspberryPi raspberryPi = RaspberryPi.Instance;
        private readonly ConfigurationForm configForm = new ConfigurationForm();
        private readonly ConfigurationConnection configConnection = new ConfigurationConnection();
        private readonly PlatformExtensions platformExtensions = PlatformExtensions.Instance;

        public Dashboard()
        {
            InitializeComponent();

            
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Yellow100, TextShade.WHITE);

            usernameField.TextChanged += (sender, EventArgs) => { UsernameField_TextChanged(sender, EventArgs, usernameField.Text); };

            
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
                UpdateConfigurationFields();
            }
        }


        private void ConfigureHeaderText()
        {
            if (!raspberryPi.IsInitialized)
            {
                DisableControls();
            }
            else
            {
                EnableControls();
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void romDisplayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void UsernameField_TextChanged(object sender, EventArgs e, string text)
        {
            if (text.Length == 0)
            {
                retropieDirectoryField.Text = "";
            }
            else
            {
                retropieDirectoryField.Text = $"/home/{text}/retropie";
            }
        }

        // TODO: Validate Form
        private void SaveAndReturnButton_Click(object sender, EventArgs e)
        {
            SetRaspberryPiFromFields();
            ConfigureHeaderText();
            romDisplayContainer.Controls.Clear();
        }

        private void SetRaspberryPiFromFields()
        {
            string ipAddress = ipAddressField.Text;
            string username = usernameField.Text;
            string password = passwordField.Text;
            string retroPieDirectory = retropieDirectoryField.Text;

            raspberryPi.Configure(ipAddress, username, password, retroPieDirectory);
        }

        public void UpdateConfigurationFields()
        {
            ipAddressField.Text = raspberryPi.IpAddress;
            usernameField.Text = raspberryPi.Username;
            passwordField.Text = raspberryPi.Password;
            retropieDirectoryField.Text = raspberryPi.RetroPieDirectory;
        }
    }
}
