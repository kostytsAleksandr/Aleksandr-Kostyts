namespace LoggerConsole.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for recording to file.
    /// </summary>
    public class FileService
    {
        private static FileService fileService;

        private FileService()
        {
        }

        /// <summary>
        /// Creating or getting fileService.
        /// </summary>
        /// <returns>fileService instance.</returns>
        public static FileService GetFileService()
        {
            if (fileService == null)
            {
                fileService = new FileService();
            }

            return fileService;
        }

        /// <summary>
        /// Creating new file for recording.
        /// </summary>
        /// <returns>fPath to crerating file.</returns>
        public string CreatingNewFile()
        {
            string pathToFile = string.Empty;
            DateTime dateTime = DateTime.UtcNow;
            pathToFile = @"d:\FileLogsDirectory" + dateTime.ToString("D") + "." + dateTime.ToString("d") + ".txt";
            Directory.CreateDirectory(@"d:\FileLogsDirectory");
            string sourceDirectory = @"d:\FileLogsDirectory";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");
                if (txtFiles.Count() >= 3)
                {
                    Directory.Delete(txtFiles.First());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            File.Create(pathToFile);
            return pathToFile;
        }

        /// <summary>
        /// Writing to txt file.
        /// </summary>
        /// <param name="pathToFile">Path to file.</param>
        /// <param name="message">Info for writing.</param>
        public void WriteInfoToFile(string pathToFile, string message)
        {
            using (StreamWriter sw = new StreamWriter(pathToFile, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(message);
            }
        }
    }
}
