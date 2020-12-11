namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Hare class.
    /// </summary>
    public sealed class Bunny : Rabbits
    {
        private readonly string color;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bunny"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTail">Lenght of tail.</param>
        /// <param name="aWild">Wild or no.</param>
        /// <param name="aColor">Color.</param>
        public Bunny(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTail, bool aWild, string aColor)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed, aLenghtOfTail, aWild)
        {
            this.color = aColor;
        }

        /// <summary>
        /// Gets a color.
        /// </summary>
        public string Color => this.color;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Length of tail: {this.LenghtOfTail}mm, Color: {this.Color}";
        }
    }
}
