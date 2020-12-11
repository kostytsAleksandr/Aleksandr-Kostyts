namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Rabbits class.
    /// </summary>
    public class Rabbits : Rodents
    {
        private readonly bool wild;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rabbits"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTail">Lenght of tail.</param>
        /// <param name="aWild">Wild or no.</param>
        public Rabbits(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTail, bool aWild)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed, aLenghtOfTail)
        {
            this.wild = aWild;
        }

        /// <summary>
        /// Gets a value indicating whether gets wild rabbit or no.
        /// </summary>
        public bool Wild => this.wild;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Length of tail: {this.LenghtOfTail}mm, Is Wild: {this.Wild}";
        }
    }
}
