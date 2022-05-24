using System;
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

        private void UsernameField_TextChanged(object sender, EventArgs e)
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
        private void SaveAndReturnButton_Click(object sender, EventArgs e)
        {
            SetRaspberryPiFromFields();
            RaiseConfigEvent?.Invoke(this, e);
            Close();
        }

        private void SetRaspberryPiFromFields()
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

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
