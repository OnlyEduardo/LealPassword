using System;
using System.Collections.Generic;

namespace LealPassword.Diagnostics
{
    internal static class LogBag
    {
        private static readonly List<Log> Logs = new List<Log>();

        private static void AddLog(Log log)
        {
            Console.WriteLine(log);
            Logs.Add(log);
        }

        internal static void AddNormalLog(string message) => AddLog(new Log(LogType.NORMAL, message));
        internal static void AddWarningLog(string message) => AddLog(new Log(LogType.WARNING, message));
        internal static void AddErrorLog(string message) => AddLog(new Log(LogType.ERROR, message));
    }
}
