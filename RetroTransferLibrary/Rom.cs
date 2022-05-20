using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RetroTransferLibrary
{
    public class Rom
    {
        private PlatformExtensions platformExtensions = new PlatformExtensions();

        private string _fileName;
        public string FileName 
        {
            get { return _fileName; } 
            private set { _fileName = Path.GetFileName(value); } 
        }

        public string LocalPath { get; set; }

        public string _platform;
        public string Platform {
            get { return _platform; }
            set { _platform = platformExtensions.GetPlatform(value); } 
        }
        public string PlatformSubPath { get; set; }
        public Rom (string localPath)
        {
            LocalPath = localPath;
        }
    }
}
