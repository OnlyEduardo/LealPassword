using LealPassword.DataBases;
using LealPassword.Diagnostics;
using LealPassword.Exceptions;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LealPassword.Data
{
    internal static class WriteController
    {
        internal static void WriteDataBase(DataBase database, string pathTosave)
        {
            Properties.Settings.Default.LastPath = pathTosave;
            Properties.Settings.Default.Save();

            var bf = new BinaryFormatter();

            try
            {
                LogBag.AddNormalLog($"Writing dataBase {database.Name} in {pathTosave}");

                using (var file = File.Create(pathTosave))
                {
                    bf.Serialize(file, Security.EncryptDataBase(database));
                }      
            }
            catch (UnauthorizedAccessException e)
            {
                var msg = $"Acesso ao caminho {pathTosave} não autorizado, tente iniciar o programa como administrador.";
                System.Windows.Forms.MessageBox.Show(msg, "Sem permissão", System.Windows.Forms.MessageBoxButtons.OK);
                LogBag.AddErrorLog(e);
                Program.QuitProgram();
            } 
            catch (Exception e)
            {
                throw new ExceptionTreat("escrever banco de dados", e);
            }
        }

        internal static void WriteLog()
        {
            try
            {
                var logs = LogBag.Logs;
                var sb = new StringBuilder();
                var path = Path.Combine(Configuration.DesktopPath, Configuration.DiagnosticConfig);
                
                foreach (var log in logs)
                    sb.AppendLine(log.Message);

                var message = sb.ToString();
                File.WriteAllText(path, message, Encoding.UTF8);
                Program.QuitProgram();
            } 
            catch
            {
                throw new ExceptionTreat("", null, true);
            }
        }
    }
}
