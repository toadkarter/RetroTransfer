﻿using System;
using System.Text;

namespace RetroTransferLibrary
{
    public class RaspberryPi
    {
        /// <summary>
        /// A name selected by the user for this Raspberry Pi.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The IP address associated with this Raspberry Pi.
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// The username that holds the installation of the Raspberry Pi.
        /// </summary>
        public string Username { get; set; }


        private string _password;

        /// <summary>
        /// The login password for the Raspberry Pi. 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Constructor for RaspberryPi class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ipAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public RaspberryPi(string name, string ipAddress, string username, string password)
        {
            Name = name;
            IpAddress = ipAddress;
            Username = username;
            Password = password;
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