using Coink.Utilities.Logs;
using NLog;
using System;

namespace Coink.Utilities
{
    /// <summary>
    /// Logs
    /// </summary>
    public class Log
    {
        private static ILogger LoggerProperty;

        /// <summary>
        /// Configuration logs
        /// </summary>
        public static void ConfigureNLog()
        {
            LoggerProperty = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Save Logs
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool SaveError(CoinkException error)
        {
            LoggerProperty.Error(String.Format("Error: {0}. Stack Trace: {1}" , error.MessageError, error.StackError));
            return true;
        }

    }
}
