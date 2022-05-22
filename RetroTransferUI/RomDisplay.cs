using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetroTransferLibrary;

namespace RetroTransferUI
{
    public partial class RomDisplay : UserControl
    {
        public Rom CurrentRom { get; private set; }
        PlatformExtensions platforms = new PlatformExtensions();

        public RomDisplay(string filePath)
        {
            InitializeComponent();
            CurrentRom = new Rom(filePath);
            romName.Text = CurrentRom.FileName;
            foreach (string platform in platforms.GetPlatforms()) 
            {
                platformExtensions.Items.Add(platform);
            }
            platformExtensions.SelectedItem = CurrentRom.Platform;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentRom.Platform = platformExtensions.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
