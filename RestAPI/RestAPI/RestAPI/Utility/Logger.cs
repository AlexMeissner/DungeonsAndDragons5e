using System;

namespace RestAPI.Utility
{
    public static class Logger
    {
        public enum LogLevel
        {
            Trace,
            Info,
            Warning,
            Error,
            Exception,
        }

        private static LogLevel Level = LogLevel.Info;

        private static void Log(string message, LogLevel level)
        {
            if (level >= Level)
            {
                switch (level)
                {
                    case LogLevel.Trace:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;

                    case LogLevel.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case LogLevel.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    case LogLevel.Exception:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }

                Console.WriteLine(string.Format("{0:d/M/yyyy HH:mm:ss} - " + message, DateTime.Now));
                Console.ResetColor();
            }
        }

        public static void SetLogLevel(LogLevel level)
        {
            Level = level;
        }

        public static void Trace(string message)
        {
            Log(message, LogLevel.Trace);
        }

        public static void Info(string message)
        {
            Log(message, LogLevel.Info);
        }

        public static void Warning(string message)
        {
            Log(message, LogLevel.Warning);
        }

        public static void Error(string message)
        {
            Log(message, LogLevel.Error);
        }

        public static void Exception(Exception exception)
        {
            Log(exception.ToString(), LogLevel.Exception);
        }
    }
}