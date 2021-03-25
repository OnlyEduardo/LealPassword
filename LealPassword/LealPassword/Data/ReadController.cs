using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LealPassword.Data
{
    internal static class ReadController
    {

        internal static bool ExistLastPath() => File.Exists(Properties.Settings.Default.LastPath);
    }
}
