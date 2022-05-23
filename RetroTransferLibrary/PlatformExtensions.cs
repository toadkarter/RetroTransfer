using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RetroTransferLibrary
{
    public class PlatformExtensions
    {
        private readonly string applicationDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        private readonly string platformsFile = "platforms.txt";
        private Dictionary<List<string>, string> platformExtensions = new Dictionary<List<string>, string>();
        private string filePath;

        /// <summary>
        /// Constructor that establishes the key value pairs.
        /// </summary>
        public PlatformExtensions()
        {
            filePath = Path.Combine(applicationDirectory, platformsFile);

            InitPlatformExtensions();
        }

        public bool PlatformsFileExists()
        {
            return File.Exists(platformsFile);
        }



        public void InitPlatformExtensions()
        {
            string[] platformsFileText = File.ReadAllLines(filePath);

            foreach (string platformExtensionsLine in platformsFileText)
            {
                string[] all = platformExtensionsLine.Split(':');
                string platform = all[0];
                string[] extensionsList = all[1].Split(',');

                List<string> extensions = new List<string>();
                foreach (string extension in extensionsList)
                {
                    extensions.Add(extension);
                }

                platformExtensions[extensions] = platform;
            }
        }


        /// <summary>
        /// Takes a string containing the current file extension and returns the name of the platform to which the file belongs.
        /// Returns null if the platform is unknown.
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public string GetPlatform(string extension)
        {
            foreach (List<string> currentPlatformExtensions in platformExtensions.Keys)
            {
                if (currentPlatformExtensions.Contains(extension))
                {
                    return platformExtensions[currentPlatformExtensions];
                }
            }
            return "";
        }

        public List<string> GetPlatforms()
        {
            List<string> platforms = new List<string>();

            foreach (string platform in platformExtensions.Values) 
            {
                platforms.Add(platform);
            }

            return platforms;
        }
    }
}
