using System;
using System.Collections.Generic;

namespace LealPassword.Diagnostics
{
    internal static class LogBag
    {
        internal static List<Log> Logs { get; } = new List<Log>();

        private static void AddLog(Log log)
        {
            Console.WriteLine(log);
            Logs.Add(log);
        }

        internal static void AddNormalLog(string message) => AddLog(new Log(LogType.NORMAL, message));
        internal static void AddWarningLog(string message) => AddLog(new Log(LogType.WARNING, message));
        internal static void AddErrorLog(Exception exception) => AddLog(new Log(LogType.ERROR, $"Message: {exception.Message}\n" +
                                                                                                $"From: {exception.Source}\n" +
                                                                                                $"StackTrace: {exception.StackTrace}\n\n" +
                                                                                                $"DataKeys: {GetKeys(exception.Data.Keys)}\n" +
                                                                                                $"DataVals: {GetValues(exception.Data.Values)}"));

        private static string GetKeys(System.Collections.ICollection keys)
        {
            var result = "";

            foreach (var key in keys)
            {
                result += $"{key} ";
            }

            return result;
        }

        private static string GetValues(System.Collections.ICollection values)
        {
            var result = "";

            foreach (var value in values)
            {
                result += $"{value} ";
            }

            return result;
        }
    }
}
