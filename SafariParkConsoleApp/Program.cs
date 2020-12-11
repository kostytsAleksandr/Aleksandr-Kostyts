namespace SafariParkConsoleApp
{
    using System;
    using SafariParkConsoleApp.Services;

    /// <summary>
    /// Class wich starts.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Point input to program.
        /// </summary>
        /// <param name="args">params.</param>
        private static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Run();
        }
    }
}
