using System;
using System.Collections.Generic;
using System.IO;

namespace RetroTransferLibrary
{
    /// <summary>
    /// Reads platforms and their associated extensions from file and adds lookup table containing such platforms and extensions.
    /// </summary>
    public class PlatformExtensions
    {
        // Variables relating to singleton pattern.
        private static PlatformExtensions _instance = null;
        private static readonly object _padlock = new object();

        /// <summary>
        /// The current directory where the program is installed.
        /// </summary>
        private readonly string _applicationDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        
        /// <summary>
        /// The name of the file containing the platform extensions.
        /// </summary>
        private readonly string _platformsFile = "platforms.txt";
        
        /// <summary>
        /// The full path to the file containing the platform extensions.
        /// </summary>
        private string _filePath;

        /// <summary>
        /// Look up table consisting of a list of possible extensions and their associated platform.
        /// </summary>
        private readonly Dictionary<List<string>, string> platformExtensionsLookup = new Dictionary<List<string>, string>();

        /// <summary>
        /// Constructor used in singleton.
        /// </summary>
        private PlatformExtensions() { }

        /// <summary>
        /// Singleton instance, the main entry point into this class.
        /// </summary>
        public static PlatformExtensions Instance
        {
            get
            {
                lock(_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new PlatformExtensions();
                    }
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Check if the platform extensions file exists.
        /// </summary>
        /// <returns></returns>
        public bool PlatformsFileExists()
        {
            return File.Exists(Path.Combine(_applicationDirectory, _platformsFile));
        }

        /// <summary>
        /// Read from the text file and create lookup table of platform extensions.
        /// </summary>
        public void InitPlatformExtensions()
        {
            _filePath = Path.Combine(_applicationDirectory, _platformsFile);

            string[] platformExtensionsText = File.ReadAllLines(_filePath);

            foreach (string platformExtensionsLine in platformExtensionsText)
            {
                try
                {
                    AddToPlatformExtensions(platformExtensionsLine);
                }
                catch (Exception)
                {

                }
                
            }
        }

        /// <summary>
        /// Return the platform that matches the input extension. Otherwise, return blank.
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns a list of all platforms contained in the platforms extension file.
        /// </summary>
        /// <returns></returns>
        public List<string> GetListOfAllPlatforms()
        {
            List<string> platforms = new List<string>();

            foreach (string platform in platformExtensionsLookup.Values)
            {
                platforms.Add(platform);
            }

            return platforms;
        }

        /// <summary>
        /// Given a particular line in the platform extensions file, format it appropriately and add to lookup table.
        /// </summary>
        /// <param name="platformExtensionsLine"></param>
        private void AddToPlatformExtensions(string platformExtensionsLine)
        {
            string[] platformExtensions = platformExtensionsLine.Split(':');

            string platform = platformExtensions[0];
            List<string> extensions = GetExtensions(platformExtensions[1].Split(','));

            platformExtensionsLookup[extensions] = platform;
        }

        /// <summary>
        /// Given an array of extensions, return list of extensions.
        /// </summary>
        /// <param name="extensionsList"></param>
        /// <returns></returns>
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
