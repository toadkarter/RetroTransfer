using System.IO;

namespace RetroTransferLibrary
{
    public class Rom
    {
        public static int _id = 0;
        
        /// <summary>
        /// Id of current Rom for ease of reference.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// File path of where the ROM is located on the user's computer.
        /// </summary>
        public string LocalPath { get; private set; }

        /// <summary>
        /// Platform to which the ROM belongs.
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// File path showing where in the RetroPie directory the rom should be placed.
        /// </summary>
        public string DestinationPath { get { return $"roms/{Platform}/{FileName}"; } }

        /// <summary>
        /// The name of the file relating to this rom.
        /// </summary>
        public string FileName { get; private set; }

        private readonly PlatformExtensions platformExtensions = PlatformExtensions.Instance;

        /// <summary>
        /// Constructor that establishes the core properties of the ROM.
        /// </summary>
        /// <param name="localPath"></param>
        public Rom (string localPath)
        {
            LocalPath = localPath;
            FileName = Path.GetFileName(LocalPath);

            string extension = Path.GetExtension(LocalPath);
            Platform = platformExtensions.GetPlatform(extension);

            // Ensuring thread safety when incrementing the static _id variable
            Id = System.Threading.Interlocked.Increment(ref _id);
        }
    }
}
