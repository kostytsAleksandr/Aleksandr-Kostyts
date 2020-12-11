namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Wolf class.
    /// </summary>
    public class Wolf : Dog
    {
        private readonly string kindOfWolf;

        /// <summary>
        /// Initializes a new instance of the <see cref="Wolf"/> class.
        /// </summary>
        /// <param name="aName">Name of Dogs.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTeeth">Lenght of tail.</param>
        /// <param name="aWild">Wild or no.</param>
        /// <param name="aKindOfWolf">Kind of wolf.</param>
        public Wolf(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTeeth, bool aWild, string aKindOfWolf)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed, aLenghtOfTeeth, aWild)
        {
            this.kindOfWolf = aKindOfWolf;
        }

        /// <summary>
        /// Gets Kind of wolf.
        /// </summary>
        public string KindOfWolf => this.kindOfWolf;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Length of teeth: {this.LenghtOfTeeth}mm, Is Wild: {this.Wild}, Kind: {this.kindOfWolf}";
        }
    }
}