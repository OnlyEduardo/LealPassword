using System;

namespace LealPassword.Data
{
    internal static class Configuration
    {
        internal static readonly string DesktopPath = $"{Environment.GetLogicalDrives()[0]}/Users/{Environment.UserName}/Desktop";
        internal static readonly string DiagnosticConfig = $"Diagnostico_LealPassword.dat";
        internal static readonly string extension = ".lp";
        internal static readonly string key = "lealpassword";
    }
}
