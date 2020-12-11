namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Dogs class.
    /// </summary>
    public class Dogs : Predators
    {
        private readonly bool wild;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dogs"/> class.
        /// </summary>
        /// <param name="aName">Name of Dogs.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTeeth">Lenght of tail.</param>
        /// <param name="aWild">Wild or no.</param>
        public Dogs(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTeeth, bool aWild)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed, aLenghtOfTeeth)
        {
            this.wild = aWild;
        }

        /// <summary>
        /// Gets a value indicating whether gets wild Dogs or no.
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
