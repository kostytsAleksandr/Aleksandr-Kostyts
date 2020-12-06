namespace TaxiStationConsole.Models
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TaxiStationConsole.Enums;

    /// <summary>
    /// Base class for any car of taxi station.
    /// </summary>
    public abstract class TaxiCar : ITaxiCar, IComparable
    {
        private readonly string name;
        private readonly string createdBy;
        private readonly Country createdCountry;
        private readonly decimal price;
        private readonly float fuelConsumption;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxiCar"/> class.
        /// </summary>
        /// <param name="aName">name.</param>
        /// <param name="aCreatedBy">created by.</param>
        /// <param name="aCreatedCountry">created country.</param>
        /// <param name="aPrice">price.</param>
        /// <param name="aFuelConsumption">fuel consumption.</param>
        protected TaxiCar(string aName, string aCreatedBy, Country aCreatedCountry, decimal aPrice, float aFuelConsumption)
        {
            this.name = aName;
            this.createdBy = aCreatedBy;
            this.createdCountry = aCreatedCountry;
            this.price = aPrice;
            this.fuelConsumption = aFuelConsumption;
        }

        /// <summary>
        /// Gets Name.
        /// </summary>
        public string Name => this.name;

        /// <summary>
        /// Gets Name.
        /// </summary>
        public abstract string BodyType { get; }

        /// <summary>
        /// Gets Created by.
        /// </summary>
        public string CreatedBy => this.createdBy;

        /// <summary>
        /// Gets Created country.
        /// </summary>
        public Country CreatedCountry { get; }

        /// <summary>
        /// Gets price.
        /// </summary>
        public decimal Price => this.price;

        /// <summary>
        /// Gets fuel consumption.
        /// </summary>
        public float FuelConsumption => this.fuelConsumption;

        /// <summary>
        /// Method wich compare TaxiCars by fuel consumption.
        /// </summary>
        /// <param name="car">object for comparable.</param>
        /// <returns>comparable value.</returns>
        public int CompareTo(object car)
        {
            var carTaxi = car as TaxiCar;
            return carTaxi != null ? this.fuelConsumption.CompareTo(carTaxi.fuelConsumption)
                : throw new Exception("I can't compare, Argument must be TaxiCar");
        }

       /// <summary>
       /// Shows car information.
       /// </summary>
       /// <returns>car info.</returns>
        public abstract string ShowCarInfo();
    }
}
