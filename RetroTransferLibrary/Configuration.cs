using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RetroTransferLibrary
{
    public class Configuration
    {
        // Consider making these being inputs
        private string applicationDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        private string configFile = "config.txt";
        private string filePath;

        public Configuration()
        {
            filePath = Path.Combine(applicationDirectory, configFile);
        }

        public bool ConfigFileExists()
        {
            return File.Exists(filePath);
        }

        public void WriteToConfig(RaspberryPi raspberryPi)
        {
            string encryptedPassword = EncryptPassword(raspberryPi.Password);
            string text = $"{raspberryPi.IpAddress},{raspberryPi.Username},{encryptedPassword},{raspberryPi.RetroPieDirectory}";
            File.WriteAllText(filePath, text);
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
