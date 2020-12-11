namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Rabbits class.
    /// </summary>
    public sealed class Squirrels : Rodents
    {
        private readonly string color;

        /// <summary>
        /// Initializes a new instance of the <see cref="Squirrels"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTail">Lenght of tail.</param>
        /// <param name="aColor">Color.</param>
        public Squirrels(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTail, string aColor)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed, aLenghtOfTail)
        {
            this.color = aColor;
        }

        /// <summary>
        /// Gets color.
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