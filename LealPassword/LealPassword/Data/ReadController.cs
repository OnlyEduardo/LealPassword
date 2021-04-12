using LealPassword.DataBases;
using LealPassword.Diagnostics;
using LealPassword.Exceptions;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LealPassword.Data
{
    internal static class ReadController
    {
        internal static bool ExistLastPath() => File.Exists(Properties.Settings.Default.LastPath);

        internal static DataBase ReadDataBase(string pathToDatabase)
        {
            try
            {
                if (!File.Exists(pathToDatabase))
                {
                    var msg = $"Não foi possível encontrar caminho '{pathToDatabase}'";
                    throw new ExceptionTreat($"encontrar caminho '{pathToDatabase}'", new Exception($"Not found to read '{pathToDatabase}'"));
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

                dataBase = Security.DecryptDataBase(dataBase);

                if (dataBase.BackgroundColor.IsEmpty)
                    dataBase.BackgroundColor = Color.White;
                if (dataBase.ForegroundColor.IsEmpty)
                    dataBase.ForegroundColor = Color.Black;

                return dataBase;
            }
            catch (Exception e)
            {
                throw new ExceptionTreat("ler banco de dados", e);
            }
        }
    }
}
