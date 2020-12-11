namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Predators mammalian.
    /// </summary>
    public class Predators : Mammals
    {
        private readonly float lenghtOfTeeth;

        /// <summary>
        /// Initializes a new instance of the <see cref="Predators"/> class.
        /// </summary>
        /// <param name="aName">Name of Сetaceans.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTeeth">Lenght of teeth.</param>
        public Predators(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTeeth)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed)
        {
            this.lenghtOfTeeth = aLenghtOfTeeth;
        }

        /// <summary>
        /// Gets lenght of teeth.
        /// </summary>
        public float LenghtOfTeeth => this.lenghtOfTeeth;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Length of teeth: {this.lenghtOfTeeth}mm";
        }
    }
}
