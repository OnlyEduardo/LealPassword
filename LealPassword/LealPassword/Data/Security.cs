using LealPassword.DataBases;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LealPassword.Data
{
    internal static class Security
    {        
        private static string Encrypt(this string val)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val)) return "";

            byte[] clearBytes = Encoding.Unicode.GetBytes(val);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Configuration.key, new byte[]
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

        private static string Decrypt(this string val)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val)) return "";

            val = val.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(val);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Configuration.key, new byte[]
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

        internal static DataBase EncryptDataBase(DataBase decryptedDataBase)
        {
            decryptedDataBase.Name = decryptedDataBase.Name.Encrypt();
            decryptedDataBase.Hash.Hashed = decryptedDataBase.Hash.Hashed.Encrypt();

            // Registers
            for (int i = 0; i < decryptedDataBase.Registers.Count; i++)
            {
                decryptedDataBase.Registers[i].Name = decryptedDataBase.Registers[i].Name.Encrypt();
                decryptedDataBase.Registers[i].User = decryptedDataBase.Registers[i].User.Encrypt();
                decryptedDataBase.Registers[i].Email = decryptedDataBase.Registers[i].Email.Encrypt();
                decryptedDataBase.Registers[i].Pass = decryptedDataBase.Registers[i].Pass.Encrypt();
                decryptedDataBase.Registers[i].Tag.Name = decryptedDataBase.Registers[i].Tag.Name.Encrypt();
            }

            // Notes
            for (int i = 0; i < decryptedDataBase.Notes.Count; i++)
            {
                decryptedDataBase.Notes[i].Name = decryptedDataBase.Notes[i].Name.Encrypt();
                decryptedDataBase.Notes[i].Text = decryptedDataBase.Notes[i].Text.Encrypt();
            }

            // PersonalInfo
            decryptedDataBase.PersonalInfo.Name = decryptedDataBase.PersonalInfo.Name.Encrypt();
            decryptedDataBase.PersonalInfo.Email = decryptedDataBase.PersonalInfo.Email.Encrypt();
            decryptedDataBase.PersonalInfo.Rg = decryptedDataBase.PersonalInfo.Rg.Encrypt();
            decryptedDataBase.PersonalInfo.Cpf = decryptedDataBase.PersonalInfo.Cpf.Encrypt();
            decryptedDataBase.PersonalInfo.ImagePath = decryptedDataBase.PersonalInfo.ImagePath.Encrypt();

            // Cards 
            for (int i = 0; i < decryptedDataBase.Cards.Count; i++)
            {
                decryptedDataBase.Cards[i].CardName = decryptedDataBase.Cards[i].CardName.Encrypt();
                decryptedDataBase.Cards[i].OnwerName = decryptedDataBase.Cards[i].OnwerName.Encrypt();
                decryptedDataBase.Cards[i].Number = decryptedDataBase.Cards[i].Number.Encrypt();
                decryptedDataBase.Cards[i].Cvv = decryptedDataBase.Cards[i].Cvv.Encrypt();
            }

            return decryptedDataBase;
        }

        internal static DataBase DecryptDataBase(DataBase encryptedDataBase)
        {
            encryptedDataBase.Name = encryptedDataBase.Name.Decrypt();
            encryptedDataBase.Hash.Hashed = encryptedDataBase.Hash.Hashed.Decrypt();

            // Registers
            for (int i = 0; i < encryptedDataBase.Registers.Count; i++)
            {
                encryptedDataBase.Registers[i].Name = encryptedDataBase.Registers[i].Name.Decrypt();
                encryptedDataBase.Registers[i].User = encryptedDataBase.Registers[i].User.Decrypt();
                encryptedDataBase.Registers[i].Email = encryptedDataBase.Registers[i].Email.Decrypt();
                encryptedDataBase.Registers[i].Pass = encryptedDataBase.Registers[i].Pass.Decrypt();
                encryptedDataBase.Registers[i].Tag.Name = encryptedDataBase.Registers[i].Tag.Name.Decrypt();
            }

            // Notes
            for (int i = 0; i < encryptedDataBase.Notes.Count; i++)
            {
                encryptedDataBase.Notes[i].Name = encryptedDataBase.Notes[i].Name.Decrypt();
                encryptedDataBase.Notes[i].Text = encryptedDataBase.Notes[i].Text.Decrypt();
            }

            // PersonalInfo
            encryptedDataBase.PersonalInfo.Name = encryptedDataBase.PersonalInfo.Name.Decrypt();
            encryptedDataBase.PersonalInfo.Email = encryptedDataBase.PersonalInfo.Email.Decrypt();
            encryptedDataBase.PersonalInfo.Rg = encryptedDataBase.PersonalInfo.Rg.Decrypt();
            encryptedDataBase.PersonalInfo.Cpf = encryptedDataBase.PersonalInfo.Cpf.Decrypt();
            encryptedDataBase.PersonalInfo.ImagePath = encryptedDataBase.PersonalInfo.ImagePath.Decrypt();

            // Cards 
            for (int i = 0; i < encryptedDataBase.Cards.Count; i++)
            {
                encryptedDataBase.Cards[i].CardName = encryptedDataBase.Cards[i].CardName.Decrypt();
                encryptedDataBase.Cards[i].OnwerName = encryptedDataBase.Cards[i].OnwerName.Decrypt();
                encryptedDataBase.Cards[i].Number = encryptedDataBase.Cards[i].Number.Decrypt();
                encryptedDataBase.Cards[i].Cvv = encryptedDataBase.Cards[i].Cvv.Decrypt();
            }

            return encryptedDataBase;
        }
    }
}
