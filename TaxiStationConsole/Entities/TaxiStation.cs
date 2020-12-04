namespace TaxiStationConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TaxiStationConsole.Enums;
    using TaxiStationConsole.Models;

    /// <summary>
    /// Entity Taxi Station.
    /// </summary>
    public class TaxiStation
    {
        /// <summary>
        /// Gets or Sets cars in all taxi station.
        /// </summary>
        public TaxiCar[] Cars { get; set; }

        /// <summary>
        /// Counting price all cars.
        /// </summary>
        /// <returns>price all cars.</returns>
        public decimal AllPrice()
        {
            decimal totalPrice = 0;
            for (int i = 0; i < this.Cars.Length; i++)
            {
                totalPrice += this.Cars[i].Price;
            }

            return totalPrice;
        }

        /// <summary>
        /// Find needed car by Country and by Created.
        /// </summary>
        /// <param name="createdBy">Company Name.</param>
        /// <param name="createdCountry">Company Country brand.</param>
        /// <returns>Car info.</returns>
        public string FindCar(string createdBy, Country createdCountry)
        {
            for (int i = 0; i < this.Cars.Length; i++)
            {
                if (this.Cars[i].CreatedBy == createdBy && this.Cars[i].CreatedCountry == createdCountry)
                {
                    return this.Cars[i].ShowCarInfo();
                }
            }

            return "Please use correct data";
        }

        /// <summary>
        /// Sort TaxiCar by fuel consumption.
        /// </summary>
        /// <returns>TaxiCar[] sorted.</returns>
        public TaxiCar[] SortCars()
        {
            TaxiCar[] taxiCars = new TaxiCar[this.Cars.Length];
            Array.Sort(taxiCars);
            return taxiCars;
        }
    }
}
