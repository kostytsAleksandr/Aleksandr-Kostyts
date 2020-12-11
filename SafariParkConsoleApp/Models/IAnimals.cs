namespace SafariParkConsoleApp.Models
{
    using System;
    using SafariParkConsoleApp.Enums;

    /// <summary>
    /// Interface animals.
    /// </summary>
    public interface IAnimals
    {
        /// <summary>
        /// Gets Name of Animal.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets Lifespan.
        /// </summary>
        TimeSpan LifeSpan { get; }

        /// <summary>
        /// Gets Continent Habitat.
        /// </summary>
        Continent ContinentHabitat { get; }
    }
}
