using LoggerLogicLibruary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoggerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter start = new Starter("logsOutput.txt","errorsOutput.txt");
            start.Run();
            Console.ReadKey();
        }
    }
}
