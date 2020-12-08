namespace TaxiStationConsole.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TaxiStationConsole.Enums;

    /// <summary>
    /// Interface for all taxi car.
    /// </summary>
    public interface ITaxiCar
    {
        /// <summary>
        /// Gets Name of taxi car.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets Type body of taxi car.
        /// </summary>
        string BodyType { get; }

        /// <summary>
        /// Gets Created company of taxi car.
        /// </summary>
        string CreatedBy { get; }

        /// <summary>
        /// Gets Created country of taxi car.
        /// </summary>
        Country CreatedCountry { get; }

        /// <summary>
        /// Gets Price of taxi car.
        /// </summary>
        decimal Price { get; }

        /// <summary>
        /// Gets Fuel Consumption of taxi car.
        /// </summary>
        float FuelConsumption { get; }
    }
}
