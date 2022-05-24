﻿using RetroTransferLibrary;
using System;
using System.Windows.Forms;

namespace RetroTransferUI
{
    public partial class RomDisplay : UserControl
    {
        public Rom CurrentRom { get; private set; }
        private readonly PlatformExtensions platforms = PlatformExtensions.Instance;

        public RomDisplay(string filePath)
        {
            InitializeComponent();
            CurrentRom = new Rom(filePath);
            romName.Text = CurrentRom.FileName;
            foreach (string platform in platforms.GetListOfAllPlatforms()) 
            {
                platformsList.Items.Add(platform);
            }
            platformsList.SelectedItem = CurrentRom.Platform;
        }

        private void PlatformList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentRom.Platform = platformsList.SelectedItem.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
