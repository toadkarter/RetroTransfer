using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Renci.SshNet;

namespace RetroTransferLibrary
{
    public class ScpConnector
    {
        // TODO - Add filepath
        // TODO - Add credentials list
        // TODO - Add password encryption https://stackoverflow.com/questions/1678555/password-encryption-decryption-code-in-net
        // TODO - Isolate the file name and extension from the filePath. Consider putting this into an individual object.
        public void SendRom(RaspberryPi raspberryPi, List<Rom> roms)
        {
            ScpClient scp = new ScpClient(raspberryPi.IpAddress, raspberryPi.Username, raspberryPi.Password);
            scp.Connect();

            foreach (Rom rom in roms)
            {
                using (Stream localFile = File.OpenRead(rom.LocalPath))
                {
                    string destinationPath = $"{raspberryPi.RetroPieDirectory}/{rom.DestinationPath}";
                    scp.Upload(localFile, destinationPath);
                }
            }
            Debug.WriteLine("Before disconnect");
            scp.Disconnect();
            Debug.WriteLine("After disconnect");
        }
    }
}
