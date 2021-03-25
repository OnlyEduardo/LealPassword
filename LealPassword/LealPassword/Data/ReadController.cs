using LealPassword.DataBases;
using LealPassword.Diagnostics;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LealPassword.Data
{
    internal static class ReadController
    {
        internal static bool ExistLastPath() => File.Exists(Properties.Settings.Default.LastPath);

        internal static DataBase ReadDataBase(string pathToDatabase)
        {
            if (!File.Exists(pathToDatabase))
            {
                var msg = $"Não foi possível encontrar caminho '{pathToDatabase}'";
                LogBag.AddErrorLog(msg);
                throw new Exception(msg);
            }

            LogBag.AddNormalLog($"Reading path: '{pathToDatabase}'");
            Properties.Settings.Default.LastPath = pathToDatabase;
            Properties.Settings.Default.Save();

            var bf = new BinaryFormatter();
            DataBase dataBase;

            using (var file = File.Open(pathToDatabase, FileMode.Open))
            {
                dataBase = (DataBase)bf.Deserialize(file);
            }

            return Security.DecryptDataBase(dataBase);
        }
    }
}
