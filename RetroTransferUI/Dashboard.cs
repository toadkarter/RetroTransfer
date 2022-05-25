using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using RetroTransferLibrary;

namespace RetroTransferUI
{
    /// <summary>
    /// The core dashboard for RetroTransferUI
    /// </summary>
    public partial class Dashboard : MaterialForm
    {
        /// <summary>
        /// Set backing field to the RaspberryPi singleton instance.
        /// </summary>
        private readonly RaspberryPi _raspberryPi = RaspberryPi.Instance;

        /// <summary>
        /// Set backing field to new instance of ConfigurationConnection class.
        /// </summary>
        private readonly ConfigurationConnection _configConnection = new ConfigurationConnection();

        /// <summary>
        /// Set backing field to the PlatformExtensions singleton instance.
        /// </summary>
        private readonly PlatformExtensions _platformExtensions = PlatformExtensions.Instance;

        /// <summary>
        /// Constructor that initialises the core elements required for the program.
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();
            InitializeMaterialSkinManager();
            SubscribeToEvents();
            CheckForPlatformExtensionsAndInitialize();
            CheckForRaspberryPiAndInitialize();
        }


        // INITIALISER METHODS

        /// <summary>
        /// User MaterialSkin library to set the color scheme for the GUI.
        /// </summary>
        private void InitializeMaterialSkinManager()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Yellow100, TextShade.WHITE);
        }

        /// <summary>
        /// Subscribe to any events required for the functioning of this form.
        /// </summary>
        private void SubscribeToEvents()
        {
            // Subscribe to event that fires when the user types something in the username field.
            usernameField.TextChanged += (sender, EventArgs) => { UsernameField_TextChanged(sender, EventArgs, usernameField.Text); };
        }

        /// <summary>
        /// Initialise _platformExtensions if 'platforms.txt' file exists, otherwise show error message and quit the program.
        /// </summary>
        private void CheckForPlatformExtensionsAndInitialize()
        {
            if (_platformExtensions.PlatformsFileExists())
            {
                _platformExtensions.InitPlatformExtensions();
            } else
            {
                MessageBox.Show("Sorry, the 'platforms.txt' file seems to be missing. Please insert 'platforms.txt' into the root directory.");
                Load += new EventHandler(DashBoard_QuitOnStart);
            }
        }

        /// <summary>
        /// Check if RaspberryPi has been configured, and if so, update the fields in the configuration tab. 
        /// Otherwise, set the tab to the configuration tab so that the user can enter the appropriate details.
        /// </summary>
        private void CheckForRaspberryPiAndInitialize()
        {
            if (_configConnection.ConfigFileExists())
            {
                _configConnection.GetRaspberryPi();
                UpdateConfigurationFields();
            } else
            {
                mainTabControl.SelectedTab = configurationTab;        
            }
        }


        // EVENTS

        /// <summary>
        /// Event that closes the form as soon as it loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashBoard_QuitOnStart(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Add drag and drop effects to the core panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RomDisplayContainer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// When event is triggered, new romDisplayContainers are created for each file dropped in the ROM container.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">List of file paths of the files dropped in the panel.</param>
        private void RomDisplayContainer_DragDrop(object sender, DragEventArgs e)
        {
            romDisplayContainer.Controls.Remove(dropRomsLabel);
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string filePath in filePaths)
            {
                romDisplayContainer.Controls.Add(new RomDisplay(filePath));
            }
        }

        /// <summary>
        /// Check if Raspberry Pi is configured or if ROMs have been added. If not, show error message. If yes, send roms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (!_raspberryPi.IsInitialized)
            {
                MessageBox.Show("Please configure your Raspberry Pi in the 'Configuration' tab before attempting to transfer ROMS!", "Error");
            }
            else if (romDisplayContainer.Contains(dropRomsLabel))
            {
                MessageBox.Show("Please add some ROMs before proceeding!", "Error");
            }
            else
            {
                SendRoms();
            }
        }

        /// <summary>
        /// Updates the directory field with default directory whenever the user types something into the username field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="text">The current contents of the username field.</param>
        private void UsernameField_TextChanged(object sender, EventArgs e, string text)
        {
            if (text.Length == 0)
            {
                retropieDirectoryField.Text = "";
            }
            else
            {
                retropieDirectoryField.Text = $"/home/{text}/RetroPie";
            }
        }

        // TODO: Validate Form
        /// <summary>
        /// Initialise Raspberry Pi based on input from user and switch back to main tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAndReturnButton_Click(object sender, EventArgs e)
        {
            SetRaspberryPiFromFields();
            romDisplayContainer.Controls.Clear();
            romDisplayContainer.Controls.Add(dropRomsLabel);
            mainTabControl.SelectedTab = mainTab;
        }

        /// <summary>
        /// Resets the configuration fields if the previous settings have not been saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == configurationTab)
            {
                UpdateConfigurationFields();
            }
        }

        /// <summary>
        /// Saves Raspberry Pi to the text config file when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_raspberryPi.IsInitialized)
            {
                _configConnection.SaveRaspberryPi();
            }
        }


        // HELPER METHODS

        /// <summary>
        /// Send ROMs to RaspberryPi and reset the ROM container if no errors have been encountered.
        /// </summary>
        private void SendRoms()
        {
            if (HasRomsWithUndetectedPlatforms())
            {
                MessageBox.Show("Could not detect the correct platform for some of the ROMs in the list. " +
                    "Please select the appropriate platform for each ROM and try again.", "Error");
                return;
            }

            List<Rom> romsToSend = GetListOfCurrentRoms();
            RomUploadForm romUploadForm = new RomUploadForm(romsToSend);
            romUploadForm.ShowDialog();

            if (!romUploadForm.ErrorsEncountered)
            {
                romDisplayContainer.Controls.Clear();
                romDisplayContainer.Controls.Add(dropRomsLabel);
            }
        }

        /// <summary>
        /// Get list of the ROMs currently in the ROM container.
        /// </summary>
        /// <returns></returns>
        private List<Rom> GetListOfCurrentRoms()
        {
            List<Rom> romsToSend = new List<Rom>();

            foreach (RomDisplay romDisplay in romDisplayContainer.Controls)
            {
                romsToSend.Add(romDisplay.CurrentRom);
            }

            return romsToSend;
        }

        /// <summary>
        /// Check if any ROMs have undetected platforms.
        /// </summary>
        /// <returns></returns>
        private bool HasRomsWithUndetectedPlatforms()
        {
            foreach (RomDisplay romDisplay in romDisplayContainer.Controls)
            {
                if (romDisplay.CurrentRom.Platform == "")
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Use content from fields to configure Raspberry Pi.
        /// </summary>
        private void SetRaspberryPiFromFields()
        {
            string ipAddress = ipAddressField.Text;
            string username = usernameField.Text;
            string password = passwordField.Text;
            string retroPieDirectory = retropieDirectoryField.Text;

            _raspberryPi.Configure(ipAddress, username, password, retroPieDirectory);
        }

        /// <summary>
        /// If the Raspberry Pi has been initialised, update the fields of the form to the current Raspberry Pi.
        /// </summary>
        public void UpdateConfigurationFields()
        {
            ipAddressField.Text = _raspberryPi.IpAddress;
            usernameField.Text = _raspberryPi.Username;
            passwordField.Text = _raspberryPi.Password;
            retropieDirectoryField.Text = _raspberryPi.RetroPieDirectory;
        }


    }
}
