using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RetroTransferLibrary
{
    public class Rom
    {
        /// <summary>
        /// File path of where the ROM is located on the user's computer.
        /// </summary>
        public string LocalPath { get; set; }

        /// <summary>
        /// Platform to which the ROM belongs.
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// File path showing where in the RetroPie directory the rom should be placed.
        /// </summary>
        public string DestinationPath { get { return $"/roms/{platform}/{fileName}{extension}"; } }

        private string fileName;
        private string extension;
        private string platform;

        private PlatformExtensions platformExtensions = new PlatformExtensions();

        /// <summary>
        /// Constructor that establishes the core properties of the ROM.
        /// </summary>
        /// <param name="localPath"></param>
        public Rom (string localPath)
        {
            LocalPath = localPath;
            fileName = Path.GetFileName(LocalPath);
            extension = Path.GetExtension(LocalPath);
            Platform = platformExtensions.GetPlatform(extension);
        }
    }
}
