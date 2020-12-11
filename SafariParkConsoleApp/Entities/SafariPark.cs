namespace SafariParkConsoleApp.Entities
{
    using System;
    using SafariParkConsoleApp.Models;

    /// <summary>
    /// Entity Safary park.
    /// </summary>
    public class SafariPark
    {
        private readonly double square;
        private readonly string country;
        private readonly string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="SafariPark"/> class.
        /// </summary>
        /// <param name="aSquare">Square.</param>
        /// <param name="aCountry">Country.</param>
        /// <param name="aName">Name of place.</param>
        public SafariPark(double aSquare, string aCountry, string aName)
        {
            this.square = aSquare;
            this.country = aCountry;
            this.name = aName;
        }

        /// <summary>
        /// Gets or Sets Mammals in Park.
        /// </summary>
        public Mammals[] Mammals { get; set; }

        /// <summary>
        /// Gets name.
        /// </summary>
        public string Name => this.name;

        /// <summary>
        /// Gets country.
        /// </summary>
        public string Country => this.country;

        /// <summary>
        /// Gets square.
        /// </summary>
        public double Square => this.square;

        /// <summary>
        /// Counting of kinds.
        /// </summary>
        /// <returns>count of kinds.</returns>
        public int CoutOfKinds()
        {
            int totalKinds = 0;
            string[] kindsOfMammals = new string[12];
            foreach (var mammals in this.Mammals)
            {
                if (mammals is Artiodactyls)
                {
                    kindsOfMammals[0] = "Artiodactyls";
                }

                if (mammals is Bunny)
                {
                    kindsOfMammals[1] = "Bunny";
                }

                if (mammals is Cats)
                {
                    kindsOfMammals[2] = "Cats";
                }

                if (mammals is Jackal)
                {
                    kindsOfMammals[3] = "Jackal";
                }

                if (mammals is Dog)
                {
                    kindsOfMammals[4] = "Dog";
                }

                if (mammals is Hare)
                {
                    kindsOfMammals[5] = "Hare";
                }

                if (mammals is Predators)
                {
                    kindsOfMammals[6] = "Predators";
                }

                if (mammals is Rabbits)
                {
                    kindsOfMammals[7] = "Rabbits";
                }

                if (mammals is Rodents)
                {
                    kindsOfMammals[8] = "Rodents";
                }

                if (mammals is Squirrels)
                {
                    kindsOfMammals[9] = "Squirrels";
                }

                if (mammals is Wolf)
                {
                    kindsOfMammals[10] = "Wolf";
                }

                if (mammals is Сetaceans)
                {
                    kindsOfMammals[11] = "Сetaceans";
                }
            }

            foreach (var kind in kindsOfMammals)
            {
                if (kind != null)
                {
                    totalKinds++;
                }
            }

            return totalKinds;
        }

        /// <summary>
        /// Sort Mammals by speed.
        /// </summary>
        /// <returns>Mammals[] sorted.</returns>
        public Mammals[] SortMammals()
        {
            Mammals[] mammals = new Mammals[this.Mammals.Length];
            Array.Sort(mammals);
            return mammals;
        }
    }
}
