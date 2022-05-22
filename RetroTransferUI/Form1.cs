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

namespace RetroTransferUI
{
    public partial class Dashboard : Form
    {

        private ScpConnector scp = new ScpConnector();

        public Dashboard()
        {
            InitializeComponent();
            //romManager.AddRomEvent += RomManager_AddRomEvent; ;
        }

        //private void RomManager_AddRomEvent(object sender, Rom e)
        //{
        //    listBox2.Items.Add(e.DestinationPath);
        //    flowLayoutPanel1.Controls.Add(new RomDisplay(e));
        //}

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

        private void button1_Click(object sender, EventArgs e)
        {

            List<Rom> romsToSend = new List<Rom>();
            foreach (RomDisplay romDisplay in flowLayoutPanel1.Controls)
            {
                romsToSend.Add(romDisplay.CurrentRom);
            }

            scp.SendRom(romsToSend, "/home/pi/retropie");

            flowLayoutPanel1.Controls.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Gray;
            int borderThickness = 2;
            ButtonBorderStyle borderStyle = ButtonBorderStyle.Dashed;

            ControlPaint.DrawBorder(e.Graphics, romDropCollector.ClientRectangle,
                borderColor, borderThickness, borderStyle,
                borderColor, borderThickness, borderStyle,
                borderColor, borderThickness, borderStyle,
                borderColor, borderThickness, borderStyle) ;
        }
    }
}
