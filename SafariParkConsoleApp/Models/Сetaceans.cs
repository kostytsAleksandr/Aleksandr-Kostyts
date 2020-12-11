namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Class cetaceans.
    /// </summary>
    public sealed class Сetaceans : Mammals
    {
        private readonly float lenght;

        /// <summary>
        /// Initializes a new instance of the <see cref="Сetaceans"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed in Water.</param>
        /// <param name="aLenght">Lenght.</param>
        public Сetaceans(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenght)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed)
        {
            this.lenght = aLenght;
        }

        /// <summary>
        /// Gets lenght.
        /// </summary>
        public float Lenght => this.lenght;

        /// <summary>
        /// Show Сetaceans info to Console.
        /// </summary>
        /// <returns>Сetaceans info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Lenght: {this.Lenght}";
        }
    }
}
