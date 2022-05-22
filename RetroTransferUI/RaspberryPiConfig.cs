using System;
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
    public partial class RaspberryPiConfig : Form
    {
        public event EventHandler<RaspberryPi> RaiseConfigEvent;

        public RaspberryPiConfig()
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
            RaspberryPi currentRaspberryPi = getRaspberryPiFromFields();
            RaiseConfigEvent?.Invoke(this, currentRaspberryPi);
            Close();
        }

        private RaspberryPi getRaspberryPiFromFields()
        {
            string ipAddress = ipAddressField.Text;
            string username= usernameField.Text;
            string password = usernameField.Text;
            string retroPieDirectory = retropieDirectoryField.Text;

            return new RaspberryPi(ipAddress, username, password, retroPieDirectory);
        }
    }
}
