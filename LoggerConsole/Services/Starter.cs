namespace LoggerConsole.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Starter.
    /// </summary>
    public class Starter
    {
        private readonly Actions action;

        /// <summary>
        /// Initializes a new instance of the <see cref="Starter"/> class.
        /// </summary>
        public Starter()
        {
            this.action = new Actions();
        }

        /// <summary>
        /// Runs actions situations.
        /// </summary>
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number)
                {
                    case 0:
                        this.action.Start();
                        break;
                    case 1:
                        this.action.WarningSituation();
                        break;
                    case 2:
                        this.action.ErrorSituation();
                        break;
                }
            }
        }
    }
}
