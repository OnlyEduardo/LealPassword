using LealPassword.Diagnostics;
using LealPassword.Exceptions;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LealPassword.Data
{
    internal static class SecretFileController
    {
        private static string Encrypt(this string val, string key)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val)) return "";

            byte[] clearBytes = Encoding.Unicode.GetBytes(val);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(key, new byte[]
                {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                    }

                    val = Convert.ToBase64String(ms.ToArray());
                }
            }
            return val;
        }

        private static string Decrypt(this string val, string key)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val)) return "";

            val = val.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(val);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(key, new byte[]
                {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                    }

                    val = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return val;
        }

        internal static bool TryEncryptFile(string path, string key, out string err)
        {
            if (!File.Exists(path) || !path.EndsWith(".txt"))
            {
                err = "Caminho inválido ou arquivo não é um arquivo de texto";
                return false;
            }

            var bf = new BinaryFormatter();
            var text = File.ReadAllText(path).Encrypt(key);

            try
            {
                LogBag.AddNormalLog($"Writing file {path}");

                using (var file = File.Create(path))
                {
                    bf.Serialize(file, new FileData()
                    {
                        Text = text,
                        Key = key.Encrypt(key),
                    });
                }

                err = "sucesso";
                return true;
            }
            catch (UnauthorizedAccessException e)
            {
                err = $"Acesso ao caminho {path} não autorizado, tente iniciar o programa como administrador.\n" +
                    $"Se ainda assim não funcionar, o arquivo deve ser modificado para leitura e gravação.";
                LogBag.AddErrorLog(e);
                return false;
            }
            catch (Exception e)
            {
                throw new ExceptionTreat("escrever banco de dados", e);
            }
        }

        internal static bool TryDecryptFile(string path, string key, out string err)
        {
            try
            {
                if (!File.Exists(path) || !path.EndsWith(".txt"))
                {
                    err = "Caminho inválido ou arquivo não é um arquivo de texto";
                    return false;
                }

                LogBag.AddNormalLog($"Reading path: '{path}'");

                var bf = new BinaryFormatter();
                FileData filedata;

                using (var file = File.Open(path, FileMode.Open))
                {
                    filedata = (FileData)bf.Deserialize(file);
                }

                string tk;
                
                try
                {
                    tk = filedata.Key.Decrypt(key);

                    if (tk != key)
                    {
                        err = "Chave inválida, não foi possivel decryptar o arquivo";
                        return false;
                    }
                }
                catch
                {
                    err = "Chave inválida, não foi possivel decryptar o arquivo";
                    return false;
                }

                var tkey = tk;
                var ttext = filedata.Text.Decrypt(key);

                File.WriteAllText(path, ttext);
                err = "sucesso";
                return true;
            }
            catch (Exception e)
            {
                throw new ExceptionTreat($"ler arquivo encryptado no caminho '{path}', pode ser devido ao antivirus.", e);
            }
        }

        [Serializable]
        private sealed class FileData
        {
            internal string Text;
            internal string Key;
        }
    }
}
