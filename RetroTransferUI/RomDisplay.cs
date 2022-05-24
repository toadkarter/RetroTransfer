using RetroTransferLibrary;
using System;
using System.Windows.Forms;

namespace RetroTransferUI
{
    public partial class RomDisplay : UserControl
    {
        /// <summary>
        /// The ROM that is represented by this RomDisplay.
        /// </summary>
        public Rom CurrentRom { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        private readonly PlatformExtensions _platformExtensions = PlatformExtensions.Instance;

        public RomDisplay(string filePath)
        {
            InitializeComponent();
            CurrentRom = new Rom(filePath);
            FillDetailsWithCurrentRom();
        }

        /// <summary>
        /// Fills the details of the RomDisplay using properties contained in the CurrentRom.
        /// </summary>
        private void FillDetailsWithCurrentRom()
        {
            romName.Text = CurrentRom.FileName;
            AddPlatformsListToDropdown();
            platformsList.SelectedItem = CurrentRom.Platform;
        }

        /// <summary>
        /// Fills dropdown with all platform extensions.
        /// </summary>
        private void AddPlatformsListToDropdown()
        {
            foreach (string platform in _platformExtensions.GetListOfAllPlatforms())
            {
                platformsList.Items.Add(platform);
            }
        }

        /// <summary>
        /// Changes the Platform property of the CurrentRom based on what the user's dropdown selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentRom.Platform = platformsList.SelectedItem.ToString();
        }

        /// <summary>
        /// Delete the RomDisplay from container when the user presses the delete button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
