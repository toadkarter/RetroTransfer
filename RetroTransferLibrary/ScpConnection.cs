using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Renci.SshNet;

namespace RetroTransferLibrary
{
    public class ScpConnection
    {
        RaspberryPi raspberryPi = RaspberryPi.Instance;
        public event EventHandler<string> RaiseStartingRomTransferEvent;

        public void SendRom(List<Rom> roms)
        {
            ScpClient scp = new ScpClient(raspberryPi.IpAddress, raspberryPi.Username, raspberryPi.Password);
            scp.Connect();

            foreach (Rom rom in roms)
            {
                using (Stream localFile = File.OpenRead(rom.LocalPath))
                {
                    RaiseStartingRomTransferEvent?.Invoke(RaiseStartingRomTransferEvent, rom.FileName);
                    string destinationPath = $"{raspberryPi.RetroPieDirectory}/{rom.DestinationPath}";
                    scp.Upload(localFile, destinationPath);
                }
            }
            scp.Disconnect();
        }
    }
}
