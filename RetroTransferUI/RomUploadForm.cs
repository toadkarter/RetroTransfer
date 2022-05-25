using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using MaterialSkin;
using MaterialSkin.Controls;
using Renci.SshNet;
using RetroTransferLibrary;

namespace RetroTransferUI
{
    public partial class RomUploadForm : MaterialForm
    {
        /// <summary>
        /// Set backing field to the RaspberryPi singleton instance.
        /// </summary>
        private readonly RaspberryPi _raspberryPi = RaspberryPi.Instance;

        /// <summary>
        /// List of ROMs that need to be sent.
        /// </summary>
        private readonly List<Rom> _roms;

        /// <summary>
        /// Property that determins if the background thread has determined any errors.
        /// </summary>
        public bool ErrorsEncountered { get; private set; } = false;

        /// <summary>
        /// Offset variables relating the progress bar to indicate that the sending process has begun.
        /// </summary>
        private int _progressBarOffset = 2;
        private int _romPercentageWithOffset;

        /// <summary>
        /// Constructor that initialises the core elements required for the program.
        /// </summary>
        public RomUploadForm(List<Rom> roms)
        {
            _roms = roms;
            InitializeComponent();
            InitializeMaterialSkinManager();
            InitializeProgressBarValues();
            SubscribeToEvents();

            // Run background thread for rom upload.
            romUploadThread.RunWorkerAsync();
        }


        // INITIALISER METHODS

        /// <summary>
        /// User MaterialSkin library to set the color scheme for the GUI.
        /// </summary>
        private void InitializeMaterialSkinManager()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        /// <summary>
        /// Initalise progress bar values based on how many ROMs need to be uploaded.
        /// </summary>
        private void InitializeProgressBarValues()
        {
            int romPercentage = (int)Math.Round(1.0 / _roms.Count * 100);
            _progressBarOffset = 2;
            _romPercentageWithOffset = romPercentage - _progressBarOffset;
        }

        /// <summary>
        /// Subscribe to any events required for the functioning of this form.
        /// </summary>
        private void SubscribeToEvents()
        {
            romUploadThread.DoWork += RomUploadThread_DoWork;
            romUploadThread.ProgressChanged += RomUploadThread_ProgressChanged;
            romUploadThread.RunWorkerCompleted += RomUploadThread_RunWorkerCompleted;
        }


        // EVENTS

        /// <summary>
        /// When the background thread starts, connect via SCP and upload the ROMs. 
        /// Log failures if there is an error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RomUploadThread_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ConnectAndUploadRoms();
            }
            catch (Exception ex)
            {
                ErrorsEncountered = true;
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        /// <summary>
        /// Whenever this event is fired, update the progress bar and the file name in the UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">File name of the file currently being uploaded.</param>
        private void RomUploadThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            sendingText.Text = e.UserState.ToString();
            progressBar.Increment(e.ProgressPercentage);
        }

        /// <summary>
        /// When all files have been uploaded, check for errors, change text and add button allowing user to return.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RomUploadThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ErrorsEncountered)
            {
                sendingText.Text = "ERROR";
            } else
            {
                sendingText.Text = "All Done!";
            }

            returnButton.Visible = true;
            returnButton.Enabled = true;
        }

        /// <summary>
        /// Close the form when the user clicks the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // HELPER METHODS

        /// <summary>
        /// Connect to Raspberry Pi using ScpClient and upload all ROMs.
        /// </summary>
        public void ConnectAndUploadRoms()
        {
            ScpClient scp = new ScpClient(_raspberryPi.IpAddress, _raspberryPi.Username, _raspberryPi.Password);
            
            scp.Connect();
            UploadAllRoms(scp);
            scp.Disconnect();
        }

        /// <summary>
        /// Loop through the ROMs and send each one to the Raspberry Pi.
        /// </summary>
        /// <param name="scp"></param>
        private void UploadAllRoms(ScpClient scp)
        {
            foreach (Rom rom in _roms)
            {
                UploadSingleRom(scp, rom);
            }
        }

        /// <summary>
        /// Open the file path of the ROM and transfer it to the appropriate directory on the Raspberry Pi.
        /// </summary>
        /// <param name="scp"></param>
        /// <param name="rom"></param>
        private void UploadSingleRom(ScpClient scp, Rom rom)
        {
            using (Stream localFile = File.OpenRead(rom.LocalPath))
            {
                // Update progress bar with a small increment showing that the transfer has started.
                romUploadThread.ReportProgress(_progressBarOffset, rom.FileName);

                string destinationPath = $"{_raspberryPi.RetroPieDirectory}/{rom.DestinationPath}";
                scp.Upload(localFile, destinationPath);

                // Update progress bar with a value proportionate to the amount of ROMs that need to be uploaded.
                romUploadThread.ReportProgress(_romPercentageWithOffset, rom.FileName);
            }
        }


    }
}
