using System;
using System.IO;
using System.Text;

namespace RetroTransferLibrary
{
    /// <summary>
    /// Class that connects to the text file and gets details about the Raspberry Pi.
    /// </summary>
    public class ConfigurationConnection
    {
        /// <summary>
        /// Reference to the current Raspberry Pi loaded into the project (if available).
        /// </summary>
        private readonly RaspberryPi _raspberryPi = RaspberryPi.Instance;

        /// <summary>
        /// Reference to the directory on the computer where this program is installed.
        /// </summary>
        private readonly string _applicationDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        
        /// <summary>
        /// The name of the configuration file.
        /// </summary>
        private readonly string _configFile = "config.txt";

        /// <summary>
        /// Exact file path of where the configuration file is located.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Constructor for the ConfigurationConnection.
        /// </summary>
        public ConfigurationConnection()
        {
            // Initialise file path by combining the application directory and the configuration file.
            _filePath = Path.Combine(_applicationDirectory, _configFile);
        }

        /// <summary>
        /// Check if the configuration file exists.
        /// </summary>
        /// <returns></returns>
        public bool ConfigFileExists()
        {
            return File.Exists(_filePath);
        }

        /// <summary>
        /// Save Raspberry Pi details to the text file.
        /// </summary>
        public void SaveRaspberryPi()
        {
            string encryptedPassword = EncryptPassword(_raspberryPi.Password);
            string text = $"{_raspberryPi.IpAddress},{_raspberryPi.Username},{encryptedPassword},{_raspberryPi.RetroPieDirectory}";
            File.WriteAllText(_filePath, text);
        }

        /// <summary>
        /// Connect to the texxt file and initialise Raspberry Pi with details contained therein.
        /// </summary>
        public void GetRaspberryPi()
        {
            string[] text = File.ReadAllText(_filePath).Split(',');
            string decryptedPassword = DecryptPassword(text[2]);
            _raspberryPi.Configure(text[0], text[1], decryptedPassword, text[3]);
        }

        /// <summary>
        /// Takes in an unencrypted password encrypts it using the Encoding C# library.
        /// </summary>
        /// <param name="unencryptedPassword"></param>
        /// <returns></returns>
        private string EncryptPassword(string unencryptedPassword)
        {
            byte[] passwordInEncryptedBytes = Encoding.UTF8.GetBytes(unencryptedPassword);
            return Convert.ToBase64String(passwordInEncryptedBytes);
        }

        /// <summary>
        /// Takes in a password encrypted using the EncryptPassword method and decrypts it.
        /// </summary>
        /// <param name="encryptedPassword"></param>
        /// <returns></returns>
        private string DecryptPassword(string encryptedPassword)
        {
            byte[] passwordInEncryptedBytes = Convert.FromBase64String(encryptedPassword);
            return Encoding.UTF8.GetString(passwordInEncryptedBytes);
        }

    }
}
