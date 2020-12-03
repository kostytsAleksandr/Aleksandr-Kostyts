namespace TaxiStationConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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
    }
}
