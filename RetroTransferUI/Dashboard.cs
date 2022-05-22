﻿using System;
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
        private RaspberryPi raspberryPi;
        private ConfigurationForm raspberryPiConfig = new ConfigurationForm();
        private ScpConnector scp = new ScpConnector();
        private ConfigurationConnection config = new ConfigurationConnection();

        public Dashboard()
        {
            InitializeComponent();
            CheckConfigForRaspberryPi();
            InitializeRaspberryPiText();
            raspberryPiConfig.RaiseConfigEvent += RaspberryPiConfig_ConfigEvent;
        }

        private void CheckConfigForRaspberryPi()
        {
            if (config.ConfigFileExists())
            {
                raspberryPi = config.GetRaspberryPiFromConfig();
            }
        }


        //private void RomManager_AddRomEvent(object sender, Rom e)
        //{
        //    listBox2.Items.Add(e.DestinationPath);
        //    flowLayoutPanel1.Controls.Add(new RomDisplay(e));
        //}

        private void RaspberryPiConfig_ConfigEvent(object sender, RaspberryPi e)
        {
            raspberryPi = e;
            InitializeRaspberryPiText();
            flowLayoutPanel1.Controls.Clear();
        }

        // Note to self: Is it safer to include the Raspberry Pi as the parameter?
        private void InitializeRaspberryPiText()
        {
            if (raspberryPi == null)
            {
                // Show alert saying that the Raspberry Pi hasn't been configured properly

            }
            else
            {
                raspberryPiDetailsText.Text = $"Sending to {raspberryPi.Username}@{raspberryPi.IpAddress}";
            }
        }


        private void romDropCollector_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                flowLayoutPanel1.Controls.Add(new RomDisplay(filePath));
            }
            // listBox1.Items.Add(filePath[0]);
            // ScpConnector scp = new ScpConnector();
            // scp.SendFile(filePath[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            List<Rom> romsToSend = new List<Rom>();

            foreach (RomDisplay romDisplay in flowLayoutPanel1.Controls)
            {
                romsToSend.Add(romDisplay.CurrentRom);
            }

            scp.SendRom(raspberryPi, romsToSend);
            Debug.Write("Sent all the roms");
            flowLayoutPanel1.Controls.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.White;
            int borderThickness = 2;
            ButtonBorderStyle borderStyle = ButtonBorderStyle.Dashed;

            ControlPaint.DrawBorder(e.Graphics, romDropCollector.ClientRectangle,
                borderColor, borderThickness, borderStyle,
                borderColor, borderThickness, borderStyle,
                borderColor, borderThickness, borderStyle,
                borderColor, borderThickness, borderStyle) ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void configButton_Click(object sender, EventArgs e)
        {
            raspberryPiConfig.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (raspberryPi != null)
            {
                config.SaveRaspberryPiToConfig(raspberryPi);
            }
        }
    }
}
