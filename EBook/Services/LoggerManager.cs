﻿using NLog;
using Services.Contracts;

namespace Services
{
    public class LoggerManager : ILoggerService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogWarning(string message) => logger.Warn(message);
        public void LogError(string message) => logger.Error(message);
    }

}
