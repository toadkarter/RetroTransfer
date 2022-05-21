using System;
using System.Collections.Generic;
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
        public void SendRom(Rom[] roms, string raspberryPiPrefixPath)
        {
            ScpClient scp = new ScpClient("ipaddress", "pi", "password");
            scp.Connect();

            foreach (Rom rom in roms)
            {
                using (Stream localFile = File.OpenRead(rom.LocalPath))
                {
                    string destinationPath = $"{raspberryPiPrefixPath}/{rom.DestinationPath}";
                    scp.Upload(localFile, destinationPath);
                }
            }
            scp.Disconnect();
        }
    }
}
