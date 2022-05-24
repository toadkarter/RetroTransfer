using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RetroTransferLibrary;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RetroTransferUI
{
    public partial class Dashboard : MaterialForm
    {
        private readonly RaspberryPi raspberryPi = RaspberryPi.Instance;
        private readonly ConfigurationConnection configConnection = new ConfigurationConnection();
        private readonly PlatformExtensions platformExtensions = PlatformExtensions.Instance;

        public Dashboard()
        {
            InitializeComponent();
            InitialiseMaterialSkinManager();

            usernameField.TextChanged += (sender, EventArgs) => { UsernameField_TextChanged(sender, EventArgs, usernameField.Text); };

            CheckPlatformFileForPlatformExtensions();
            CheckConfigFileForRaspberryPi();
        }

        private void InitialiseMaterialSkinManager()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Yellow100, TextShade.WHITE);
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
            } else
            {
                mainTabControl.SelectedTab = configurationTab;        
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
            if (!raspberryPi.IsInitialized)
            {
                MessageBox.Show("Please configure your Raspberry Pi in the 'Configuration' tab before attempting to transfer ROMS!");
            } else
            {
                SendRoms();
            }
        }

        private void SendRoms()
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
            romDisplayContainer.Controls.Clear();
            if (!mainTabControl.Controls.Contains(mainTab))
            {
                mainTabControl.Controls.Add(mainTab);
            }
            mainTabControl.SelectedTab = mainTab;
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
