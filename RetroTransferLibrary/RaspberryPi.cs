using System;
using System.Text;

namespace RetroTransferLibrary
{
    public class RaspberryPi
    {

        /// <summary>
        /// The IP address associated with this Raspberry Pi.
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// The username that holds the installation of the Raspberry Pi.
        /// </summary>
        public string Username { get; set; }

        public string RetroPieDirectory { get; set; }


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
        public RaspberryPi(string ipAddress, string username, string password, string retroPieDirectory)
        {
            IpAddress = ipAddress;
            Username = username;
            Password = password;
            RetroPieDirectory = retroPieDirectory;
        }
    }
}
