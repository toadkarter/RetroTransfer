using System;
using System.Collections.Generic;
using System.Text;

namespace RetroTransferLibrary
{
    public class PlatformExtensions
    {
        // This is ugly as sin, figure out a way to read this in from an enum or something.

        private Dictionary<List<string>, string> platformExtensions = new Dictionary<List<string>, string>();

        /// <summary>
        /// Constructor that establishes the key value pairs.
        /// </summary>
        public PlatformExtensions()
        {
            initPlatformExtensions();
        }

        public void initPlatformExtensions()
        {
            platformExtensions[new List<string> { ".gba" }] = "gba";
            platformExtensions[new List<string> { ".gb" }] = "gb";
            platformExtensions[new List<string> { ".gbc" }] = "gbc";
            platformExtensions[new List<string> { ".z64", ".n64", ".v64" }] = "n64";
            platformExtensions[new List<string> { ".nes" }] = "nes";
            platformExtensions[new List<string> { ".smc", ".sfc" }] = "snes";
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
