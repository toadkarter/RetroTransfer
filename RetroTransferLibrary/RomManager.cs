using System;
using System.Collections.Generic;
using System.Text;

namespace RetroTransferLibrary
{
    public class RomManager
    {
        public List<Rom> CurrentRoms { get; private set; }

        public RomManager()
        {
            CurrentRoms = new List<Rom>();
        }

        public void addRom(string localPath)
        {
            Rom currentRom = new Rom(localPath);
            CurrentRoms.Add(currentRom);
        }

        public void deleteRom(string fileName)
        {
            foreach (Rom rom in CurrentRoms)
            {
                if (rom.FileName == fileName)
                {
                    CurrentRoms.Remove(rom);
                }
            }
        }

        public void deleteAllRoms()
        {
            CurrentRoms.Clear();
        }
    }
}
