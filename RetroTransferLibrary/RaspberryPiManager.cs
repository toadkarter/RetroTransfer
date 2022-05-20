using System;
using System.Collections.Generic;
using System.Text;

namespace RetroTransferLibrary
{
    public sealed class RaspberryPiManager
    {
        private List<RaspberryPi> _raspberryPis = new List<RaspberryPi>();

        /// <summary>
        /// Property containing the list of all currently saved Raspberry Pis.
        /// </summary>
        public List<RaspberryPi> RaspberryPis { get; }
       
        private static RaspberryPiManager _instance = null;

        /// <summary>
        /// Lock to ensure that singleton pattern works properly with multithreading.
        /// </summary>
        private static readonly object padlock = new object();

        /// <summary>
        /// Empty constructor for singleton pattern.
        /// </summary>
        RaspberryPiManager() { }

        /// <summary>
        /// Instance property that implements the singleton pattern.
        /// </summary>
        public static RaspberryPiManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (Instance == null)
                    {
                        _instance = new RaspberryPiManager();
                    }
                    return _instance;
                }
            }
        }

        public void AddAllFromConfig()
        {
            // Loop through the text and populate the list of Raspberry Pis
        }

        public void SaveAllToConfig()
        {
            // Loop through the list and populate the text file with all Raspberry Pis
        }

        /// <summary>
        /// Creates an instance of Raspberry Pi and adds it to the list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ipAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void AddRaspberryPi(string name, string ipAddress, string username, string password)
        {
            RaspberryPi raspberryPi = new RaspberryPi(name, ipAddress, username, password);
            _raspberryPis.Add(raspberryPi);
        }

        /// <summary>
        /// Searches the list for a Raspberry Pi with a particular name and removes it from the list.
        /// </summary>
        /// <param name="name"></param>
        public void DeleteRaspberryPi(string name)
        {
            foreach (RaspberryPi raspberryPi in _raspberryPis)
            {
                if (raspberryPi.Name == name)
                {
                    _raspberryPis.Remove(raspberryPi);
                    return;
                }
            }
        }
    }
}
