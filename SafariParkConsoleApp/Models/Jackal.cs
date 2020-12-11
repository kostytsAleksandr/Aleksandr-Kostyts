namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Jackal class.
    /// </summary>
    public sealed class Jackal : Dog
    {
        private readonly string kindOfJackal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Jackal"/> class.
        /// </summary>
        /// <param name="aName">Name of Dogs.</param>
        /// <param name="aLifeSpan">Lifespan of Сetaceans.</param>
        /// <param name="aContinentHabitat">Continent where Сetaceans live.</param>
        /// <param name="aSpeed">Speed on Serface.</param>
        /// <param name="aLenghtOfTeeth">Lenght of tail.</param>
        /// <param name="aWild">Wild or no.</param>
        /// <param name="aKindOfJackal">Kind of jackal.</param>
        public Jackal(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed, float aLenghtOfTeeth, bool aWild, string aKindOfJackal)
            : base(aName, aLifeSpan, aContinentHabitat, aSpeed, aLenghtOfTeeth, aWild)
        {
            this.kindOfJackal = aKindOfJackal;
        }

        /// <summary>
        /// Gets Kind of Jackal.
        /// </summary>
        public string KindOfJackal => this.kindOfJackal;

        /// <summary>
        /// Show info.
        /// </summary>
        /// <returns>info.</returns>
        public override string ShowInfo()
        {
            return $"Name: {this.Name}, Continent Habitat: {this.ContinentHabitat}, Speed: {this.Speed}, Length of teeth: {this.LenghtOfTeeth}mm, Is Wild: {this.Wild}, Kind: {this.kindOfJackal}";
        }
    }
}