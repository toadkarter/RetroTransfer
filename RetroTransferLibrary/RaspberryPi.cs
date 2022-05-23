using System;
using System.Text;

namespace RetroTransferLibrary
{
    public class RaspberryPi
    {
        private static RaspberryPi instance = null;
        private static readonly object padlock = new object();

        RaspberryPi() { }

        public static RaspberryPi Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new RaspberryPi();
                    }
                    return instance;
                }
            }
        }

        public string IpAddress { get; private set; }
        public string Username { get; private set; }
        public string RetroPieDirectory { get; private set; }
        public string Password { get; private set; }
        public bool IsInitialized { get; private set; } = false;

        public void Configure(string ipAddress, string username, string password, string retroPieDirectory)
        {
            IsInitialized = true;
            IpAddress = ipAddress;
            Username = username;
            Password = password;
            RetroPieDirectory = retroPieDirectory;
        }
    }
}
