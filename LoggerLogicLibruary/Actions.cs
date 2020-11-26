using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLogicLibruary
{
    public class Actions
    {
        public Actions(string pathTofile)
        {
            _logger = Logger.CreateLogger(pathTofile);
        }

        private Logger _logger;

        public void Start()
        {
            _logger.IsInfo = true;
            Console.WriteLine(_logger.ShowLoggerInfo("Start"));
        }

        public void WarningSituation()
        {
            _logger.IsWarning = true;
            Console.WriteLine(_logger.ShowLoggerInfo("Skipped logic in method"));
        }

        public void ErrorSituation()
        {
            _logger.IsError = true;
            _logger.ShowLoggerInfo("I broke a toilet");
            throw new Exception("I broke a toilet");
        }
    }
}
