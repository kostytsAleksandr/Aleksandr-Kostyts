namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Abstract Class Mammals.
    /// </summary>
    public abstract class Mammals : IAnimals
    {
        private readonly string name;
        private readonly TimeSpan lifeSpan;
        private readonly Continent continentHabitat;
        private readonly float speed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammals"/> class.
        /// </summary>
        /// <param name="aName">Name of mammalian.</param>
        /// <param name="aLifeSpan">Lifespan of mammalian.</param>
        /// <param name="aContinentHabitat">Continent where mammalian live.</param>
        /// <param name="aSpeed">Speed on Earth or in Water.</param>
        protected Mammals(string aName, TimeSpan aLifeSpan, Continent aContinentHabitat, float aSpeed)
        {
            this.name = aName;
            this.lifeSpan = aLifeSpan;
            this.continentHabitat = aContinentHabitat;
            this.speed = aSpeed;
        }

        /// <summary>
        /// Gets a name of mammalian.
        /// </summary>
        public string Name => this.name;

        /// <summary>
        /// Gets average lifespan.
        /// </summary>
        public TimeSpan LifeSpan => this.lifeSpan;

        /// <summary>
        /// Gets continent habitat.
        /// </summary>
        public Continent ContinentHabitat => this.continentHabitat;

        /// <summary>
        /// Gets speed.
        /// </summary>
        public float Speed => this.speed;

        /// <summary>
        /// Method wich compare Mammals by speed.
        /// </summary>
        /// <param name="aMammalian">object for comparable.</param>
        /// <returns>comparable value.</returns>
        public int CompareTo(object aMammalian)
        {
            var mammalian = aMammalian as Mammals;
            return mammalian != null ? this.speed.CompareTo(mammalian.speed)
                : throw new Exception("I can't compare, Argument must be Mammals");
        }

        /// <summary>
        /// Shows car information.
        /// </summary>
        /// <returns>car info.</returns>
        public abstract string ShowInfo();
    }
}
