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
        public void SendFile(String fileName)
        {
            ScpClient scp = new ScpClient("ipaddress", "pi", "password");
            scp.Connect();

            using (Stream localFile = File.OpenRead(fileName))
            {
                String destinationFile = $"/home/pi/{fileName}";
                scp.Upload(localFile, destinationFile);
            }

            scp.Disconnect();
        }
    }
}
