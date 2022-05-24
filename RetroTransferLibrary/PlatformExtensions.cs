using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RetroTransferLibrary
{
    public class PlatformExtensions
    {
        private static PlatformExtensions instance = null;
        private static readonly object padlock = new object();

        private readonly string applicationDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        private readonly string platformsFile = "platforms.txt";
        private string filePath;

        private readonly Dictionary<List<string>, string> platformExtensionsLookup = new Dictionary<List<string>, string>();

        public PlatformExtensions() { }

        public static PlatformExtensions Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new PlatformExtensions();
                    }
                    return instance;
                }
            }
        }

        public bool PlatformsFileExists()
        {
            return File.Exists(Path.Combine(applicationDirectory, platformsFile));
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

        public void InitPlatformExtensions()
        {
            filePath = Path.Combine(applicationDirectory, platformsFile);

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
