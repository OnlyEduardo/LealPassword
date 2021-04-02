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
            LogBag.AddNormalLog($"Writing dataBase {database.Name} in {pathTosave}");
            Properties.Settings.Default.LastPath = pathTosave;

            var bf = new BinaryFormatter();
            using (var file = File.Create(pathTosave))
            {
                bf.Serialize(file, Security.EncryptDataBase(database));
            }
        }
    }
}
