namespace TaxiStationConsole.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TaxiStationConsole.Entities;
    using TaxiStationConsole.Models;

    /// <summary>
    /// Created Taxi Station.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Created Taxi Station and testing.
        /// </summary>
        public void Run()
        {
            TaxiStation station = new TaxiStation();
            station.Cars = new TaxiCar[7];
            for (int i = 0; i < 7; i++)
            {
                station.Cars[i] = new HachBackCar("3", "Mazda", Enums.Country.Japan, 30000m, 6.1f);
                station.Cars[i] = new MiniVanCar("CX9", "Mazda", Enums.Country.Japan, 50000.560m, 8.1f);
                station.Cars[i] = new MiniVanCar("X6", "BMW", Enums.Country.Germany, 115000.999m, 11.1f);
                station.Cars[i] = new HachBackCar("Tipo", "Fiat", Enums.Country.Italy, 120000m, 4.1f);
                station.Cars[i] = new SedanCar("Vesta", "Lada", Enums.Country.Russia, 10000m, 6.0f);
                station.Cars[i] = new SedanCar("RSX", "Acura", Enums.Country.Japan, 40000m, 12.1f);
                station.Cars[i] = new HachBackCar("TT", "Audi", Enums.Country.Germany, 70000m, 9.1f);
            }

            station.SortCars();
            for (int i = 0; i < station.Cars.Length; i++)
            {
                Console.WriteLine(station.Cars[i].ShowCarInfo());
            }

            Console.WriteLine(station.FindCar("Mazda", Enums.Country.Japan));
            Console.WriteLine(station.FindCar("Mazda", Enums.Country.Germany));
            Console.WriteLine(station.FindCar("Audi", Enums.Country.Germany));
            Console.ReadKey();
        }
    }
}
