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
        private readonly string filePath;

        private readonly Dictionary<List<string>, string> platformExtensionsLookup = new Dictionary<List<string>, string>();


        public PlatformExtensions()
        {
            filePath = Path.Combine(applicationDirectory, platformsFile);
            InitPlatformExtensions();
        }

        public bool PlatformsFileExists()
        {
            return File.Exists(platformsFile);
        }

        public string GetPlatform(string extension)
        {
            foreach (List<string> currentPlatformExtensions in platformExtensionsLookup.Keys)
            {
                if (currentPlatformExtensions.Contains(extension))
                {
                    return platformExtensionsLookup[currentPlatformExtensions];
                }
            }
            return "";
        }

        public List<string> GetListOfAllPlatforms()
        {
            List<string> platforms = new List<string>();

            foreach (string platform in platformExtensionsLookup.Values)
            {
                platforms.Add(platform);
            }

            return platforms;
        }

        private void InitPlatformExtensions()
        {
            string[] platformExtensionsText = File.ReadAllLines(filePath);

            foreach (string platformExtensionsLine in platformExtensionsText)
            {
                AddToPlatformExtensions(platformExtensionsLine);
            }
        }

        private void AddToPlatformExtensions(string platformExtensionsLine)
        {
            string[] platformExtensions = platformExtensionsLine.Split(':');

            string platform = platformExtensions[0];
            List<string> extensions = GetExtensions(platformExtensions[1].Split(','));

            platformExtensionsLookup[extensions] = platform;
        }

        private List<string> GetExtensions(string[] extensionsList)
        {
            List<string> extensions = new List<string>();
            foreach (string extension in extensionsList)
            {
                extensions.Add(extension);
            }

            return extensions;
        }
    }
}
