using System;
using System.Collections.Generic;
using System.Text;

namespace RetroTransferLibrary
{
    public class PlatformExtensions
    {
        private Dictionary<List<string>, string> platformExtensions = new Dictionary<List<string>, string>();
        
        /// <summary>
        /// Constructor that establishes the key value pairs.
        /// </summary>
        public PlatformExtensions()
        {
            initPlatformExtensions();
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

        /// <summary>
        /// Sets up dictionary of key value pairs, where the keys are a list of possible extensions and the value is the platform.
        /// </summary>
        private void initPlatformExtensions()
        {
            /// Note - consider reading this from a text file somewhere.
            platformExtensions[new List<string> { ".gba" }] = "gba";
            platformExtensions[new List<string> { ".gb" }] = "gb";
            platformExtensions[new List<string> { ".gbc" }] = "gbc";
            platformExtensions[new List<string> { ".z64", ".n64", ".v64" }] = "n64";
            platformExtensions[new List<string> { ".nes" }] = "nes";
            platformExtensions[new List<string> { ".smc", ".sfc" }] = "snes";
        }
    }
}
