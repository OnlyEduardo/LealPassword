using LealPassword.DataBases;
using LealPassword.Diagnostics;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LealPassword.Data
{
    internal static class WriteController
    {
        internal static void WriteDataBase(DataBase database, string pathTosave)
        {
            if (!Directory.Exists(pathTosave))
            {
                var msg = $"Não foi possível encontrar caminho '{pathTosave}'";
                LogBag.AddErrorLog(msg);
                throw new Exception(msg);
            }

            LogBag.AddNormalLog($"Writing dataBase {database.Name} in {pathTosave}");

            var bf = new BinaryFormatter();
            var path = Path.Combine(pathTosave, $"{database.Name}{Configuration.extension}");
            Properties.Settings.Default.LastPath = path;

            using (var file = File.Create(path))
            {
                bf.Serialize(file, Security.EncryptDataBase(database));
            }
        }
    }
}
