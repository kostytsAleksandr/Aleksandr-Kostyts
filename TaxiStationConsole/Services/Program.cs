namespace TaxiStationConsole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TaxiStationConsole.Services;

    /// <summary>
    /// Start Point of app.
    /// </summary>
    public class Program
    {/// <summary>
    /// Start app.
    /// </summary>
    /// <param name="args">input args.</param>
        public static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Run();
        }
    }
}
