namespace SafariParkConsoleApp.Services
{
    using System;
    using SafariParkConsoleApp.Entities;
    using SafariParkConsoleApp.Models;

    /// <summary>
    /// Created Safary park.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Created Taxi Station and testing.
        /// </summary>
        public void Run()
        {
            SafariPark park = new SafariPark(10198.99, "Russia", "Central Siberian Reserve");
            park.Mammals = new Models.Mammals[9];
            for (int i = 0; i < 9; i++)
            {
                park.Mammals[0] = new Wolf("Siberian Wolf", new TimeSpan(2920, 2, 1, 0, 0), Enums.Continent.Asia, 40, 14, true, "Wolf");
                park.Mammals[1] = new Dogs("Fox", new TimeSpan(2020, 2, 1, 0, 0), Enums.Continent.Asia, 30, 14, true);
                park.Mammals[1] = new Artiodactyls("sable", new TimeSpan(4520, 2, 1, 0, 0), Enums.Continent.Asia, 30, 160);
                park.Mammals[1] = new Cats("lynx", new TimeSpan(2920, 2, 1, 0, 0), Enums.Continent.Asia, 45, 22, true);
                park.Mammals[1] = new Rodents("wolverine", new TimeSpan(2920, 2, 1, 0, 0), Enums.Continent.Asia, 28, 260);
                park.Mammals[1] = new Rodents("badger", new TimeSpan(1920, 2, 1, 0, 0), Enums.Continent.Asia, 30, 140);
                park.Mammals[1] = new Dogs("elk", new TimeSpan(4920, 2, 1, 0, 0), Enums.Continent.Asia, 30, 14, true);
            }

            try
            {
                Array.Sort(park.Mammals);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadKey();
        }
    }
}
