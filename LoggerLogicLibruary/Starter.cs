using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLogicLibruary
{
    public class Starter
    {
        private string _pathToErrorsFile;
        private Actions _action;
        public Starter(string pathToFileForLogs, string pathToFileForErrors)
        {
            _action = new Actions(pathToFileForLogs);
            _pathToErrorsFile = pathToFileForErrors;
        }
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Random random = new Random();
                    int number=random.Next(0, 3);
                    switch (number)
                    {
                        case 0:
                            _action.Start();
                            break;
                        case 1:
                            _action.WarningSituation();
                            break;
                        case 2:
                            _action.ErrorSituation();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText(_pathToErrorsFile, ex.Message + Environment.NewLine);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
