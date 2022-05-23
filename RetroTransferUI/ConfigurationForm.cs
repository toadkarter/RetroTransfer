﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetroTransferLibrary;

namespace RetroTransferUI
{
    public partial class ConfigurationForm : Form
    {
        private RaspberryPi raspberryPi = RaspberryPi.Instance;
        public event EventHandler RaiseConfigEvent;

        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (currentTextBox.Text == "")
            {
                retropieDirectoryField.Text = "";
            } else
            {
                retropieDirectoryField.Text = $"/home/{currentTextBox.Text}/retropie";
            }
        }

        // TODO: Validate Form
        private void saveAndReturnButton_Click(object sender, EventArgs e)
        {
            setRaspberryPiFromFields();
            RaiseConfigEvent?.Invoke(this, e);
            Close();
        }

        private void setRaspberryPiFromFields()
        {
            string ipAddress = ipAddressField.Text;
            string username= usernameField.Text;
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

        private void raspberryPiConfigTitleText_Click(object sender, EventArgs e)
        {

        }
    }
}
