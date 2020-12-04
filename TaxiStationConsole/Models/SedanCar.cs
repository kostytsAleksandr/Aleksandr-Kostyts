namespace TaxiStationConsole.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TaxiStationConsole.Enums;

    /// <summary>
    /// Sedan Car.
    /// </summary>
    public class SedanCar : TaxiCar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SedanCar"/> class.
        /// </summary>
        /// <param name="aName">name.</param>
        /// <param name="aCreatedBy">created by.</param>
        /// <param name="aCreatedCountry">created country.</param>
        /// <param name="aPrice">price.</param>
        /// <param name="aFuelConsumption">fuel consumption.</param>
        public SedanCar(string aName, string aCreatedBy, Country aCreatedCountry, decimal aPrice, float aFuelConsumption)
            : base(aName, aCreatedBy, aCreatedCountry, aPrice, aFuelConsumption)
        {
        }

        /// <summary>
        /// Gets Type of body.
        /// </summary>
        public override string BodyType => "Sedan";

        /// <summary>
        /// Shows info about current car.
        /// </summary>
        /// <returns>car info.</returns>
        public override string ShowCarInfo()
        {
            return $"Name: {this.Name}, Created By: {this.CreatedBy}, Created Country: {this.CreatedCountry}";
        }
    }
}