namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Cats class.
    /// </summary>
    public sealed class Cats : Predators
    {
        private readonly bool wild;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cats"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTeeth">Lenght of teeth.</param>
        /// <param name="aWild">Wild or no.</param>
        public Cats(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTeeth, bool aWild)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed, aLenghtOfTeeth)
        {
            this.wild = aWild;
        }

        /// <summary>
        /// Gets a value indicating whether gets wild cat or no.
        /// </summary>
        public bool Wild => this.wild;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Length of teeth: {this.LenghtOfTeeth}mm, Is Wild: {this.Wild}";
        }
    }
}
