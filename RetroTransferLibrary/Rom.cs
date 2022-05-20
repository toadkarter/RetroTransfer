using System;
using System.Collections.Generic;
using System.Text;

namespace RetroTransferLibrary
{
    public class Rom
    {
        public string FileName { get; set; }
        public string LocalPath { get; set; }
        public string Platform { get; set; }
        public string PlatformSubPath { get; set; }
        public Rom (string localPath)
        {
            LocalPath = localPath;
        }
    }
}
