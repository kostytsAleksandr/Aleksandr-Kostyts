namespace LoggerConsole.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for Logs.
    /// </summary>
    public class Logger
    {
        private static Logger logger;
        private readonly FileService fileService;

        private Logger()
        {
            this.fileService = FileService.GetFileService();
        }

        /// <summary>
        /// Creating and getting logger.
        /// </summary>
        /// <returns>logger.</returns>
        public static Logger GetLogger()
        {
            if (logger == null)
            {
                logger = new Logger();
            }

            return logger;
        }

        /// <summary>
        /// Creating Logs Message.
        /// </summary>
        /// <param name="typeLogs">Enums.TypeLogs.</param>
        /// <param name="inputMessage">Inputs message.</param>
        /// <returns>message.</returns>
        public string CreateLogInfo(Enums.TypeLogs typeLogs, string inputMessage = "")
        {
            string message = string.Empty;
            DateTime dateTime = DateTime.UtcNow;
            message = dateTime.ToString("d");
            if (typeLogs == Enums.TypeLogs.Info)
            {
                message += " Start method";
            }

            if (typeLogs == Enums.TypeLogs.Warning)
            {
                message += "Action got this custom Exception: ";
                message += inputMessage;
            }

            if (typeLogs == Enums.TypeLogs.Error)
            {
                message += "Action failed by reason: ";
                message += inputMessage;
            }

            return message;
        }

        /// <summary>
        /// Pushing logs info.
        /// </summary>
        /// <param name="logsInfo">Info fo pushing.</param>
        public void PushLoggerInfo(string logsInfo)
        {
            string pathToFile = this.fileService.CreatingNewFile();
            this.fileService.WriteInfoToFile(pathToFile, logsInfo);
        }
    }
}
