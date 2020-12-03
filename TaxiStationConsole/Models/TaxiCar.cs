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
        private readonly string _name;
        private readonly string _createdBy;
        private readonly Country _createdCountry;
        private readonly decimal _price;
        private readonly float _fuelConsumption;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxiCar"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="createdBy">created by.</param>
        /// <param name="createdCountry">created country.</param>
        /// <param name="price">price.</param>
        /// <param name="fuelConsumption">fuel consumption.</param>
        protected TaxiCar(string name, string createdBy, Country createdCountry, decimal price, float fuelConsumption)
        {
            this._name = name;
            this._createdBy = createdBy;
            this._createdCountry = createdCountry;
            this._price = price;
            this._fuelConsumption = fuelConsumption;
        }

        /// <summary>
        /// Gets Name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets Created by.
        /// </summary>
        public string CreatedBy { get; }

        /// <summary>
        /// Gets Created country.
        /// </summary>
        public Country CreatedCountry { get; }

        /// <summary>
        /// Gets price.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Gets fuel consumption.
        /// </summary>
        public float FuelConsumption { get; }

        /// <summary>
        /// Method wich compare TaxiCars by fuel consumption.
        /// </summary>
        /// <param name="car">object for comparable.</param>
        /// <returns>comparable value.</returns>
        public int CompareTo(object car)
        {
            var carTaxi = car as TaxiCar;
            return carTaxi != null ? this._fuelConsumption.CompareTo(carTaxi._fuelConsumption)
                : throw new Exception("I can't compare, Argument must be TaxiCar");
        }
    }
}
