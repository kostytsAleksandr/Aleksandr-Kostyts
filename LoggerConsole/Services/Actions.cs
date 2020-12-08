namespace LoggerConsole.Services
{
    using System;
    using LoggerConsole.Exceptions;

    /// <summary>
    /// Class with Actions.
    /// </summary>
    public class Actions
    {
        private readonly Logger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Actions"/> class.
        /// </summary>
        public Actions()
        {
            this.logger = Logger.GetLogger();
        }

        /// <summary>
        /// Starting situation.
        /// </summary>
        public void Start() => this.logger.PushLoggerInfo(this.logger.CreateLogInfo(Enums.TypeLogs.Info));

        /// <summary>
        /// Warning situation.
        /// </summary>
        public void WarningSituation()
        {
            BusinessException businessException = new BusinessException("Skipped logic in method: ");
            this.logger.PushLoggerInfo(this.logger.CreateLogInfo(Enums.TypeLogs.Warning, businessException.Message));
        }

        /// <summary>
        /// Error situation.
        /// </summary>
        public void ErrorSituation()
        {
            Exception exception = new Exception("I broke a toilet: ");
            this.logger.PushLoggerInfo(this.logger.CreateLogInfo(Enums.TypeLogs.Warning, exception.Message));
        }
    }
}
