namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Artiodactyls class.
    /// </summary>
    public sealed class Artiodactyls : Mammals
    {
        private readonly float height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Artiodactyls"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aHeight">Lenght.</param>
        public Artiodactyls(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aHeight)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed)
        {
            this.height = aHeight;
        }

        /// <summary>
        /// Gets lenght.
        /// </summary>
        public float Lenght => this.height;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Height: {this.height}";
        }
    }
}
