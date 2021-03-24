using System;

namespace LealPassword.Diagnostics
{
    internal sealed class Log
    {
        internal Log(LogType logType, string message)
        {
            Message = $"[{DateTime.Now.ToShortDateString()} - {DateTime.Now.ToShortTimeString()}] " +
                $"{Enum.GetName(typeof(LogType), logType)}: {message}";
        }

        internal string Message { get; }

        public override string ToString() => Message;
    }
}
