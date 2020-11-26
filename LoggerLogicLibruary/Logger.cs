using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLogicLibruary
{
    public class Logger
    {
        public static Logger CreateLogger(string pathToWriteInfo)
        {
            return new Logger(pathToWriteInfo);
        }
        private Logger(string pathToWriteInfo)
        {
            _pathToFile = pathToWriteInfo;
            IsError = false;
            IsInfo = false;
            IsWarning = false;
        }

        private readonly string _pathToFile;
        public bool IsError { get; set; }
        public bool IsWarning { get; set; }
        public bool IsInfo { get; set; }

        public string ShowLoggerInfo(string message)
        {
            string loggerText = string.Empty;
            if (IsError)
            {
                IsWarning = false;
                IsInfo = false;
                loggerText= $"{DateTime.Now}: Error: {message}";
            }
            if (IsWarning)
            {
                IsInfo = false;
                IsError = false;
                loggerText = $"{DateTime.Now}: Warning: {message}";
            }
            if (IsInfo)
            {
                IsWarning = false;
                IsError = false;
                loggerText = $"{DateTime.Now}: Info: {message}";
            }
            File.AppendAllText(_pathToFile, loggerText + Environment.NewLine);
            return loggerText;
        }
    }
}
