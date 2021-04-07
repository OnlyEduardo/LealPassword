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
            Properties.Settings.Default.LastPath = pathTosave;
            var bf = new BinaryFormatter();

            try
            {
                LogBag.AddNormalLog($"Writing dataBase {database.Name} in {pathTosave}");
                using (var file = File.Create(pathTosave))
                {
                    bf.Serialize(file, Security.EncryptDataBase(database));
                }      
            }
            catch (UnauthorizedAccessException)
            {
                var msg = $"Acesso ao caminho {pathTosave} não autorizado";
                System.Windows.Forms.MessageBox.Show(msg, "Sem permissão", System.Windows.Forms.MessageBoxButtons.OK);
                LogBag.AddErrorLog(msg);
                Program.QuitProgram();
                return;
            }
        }
    }
}
