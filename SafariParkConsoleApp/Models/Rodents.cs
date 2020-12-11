namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Rodents class.
    /// </summary>
    public class Rodents : Mammals
    {
        private readonly float lenghtOfTail;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rodents"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTail">Lenght of tail.</param>
        public Rodents(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTail)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed)
        {
            this.lenghtOfTail = aLenghtOfTail;
        }

        /// <summary>
        /// Gets lenght of tail.
        /// </summary>
        public float LenghtOfTail => this.lenghtOfTail;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Length of tail: {this.lenghtOfTail}mm";
        }
    }
}
