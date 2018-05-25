using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EndeApp.Library
{
    public partial class Encryption
    {

        public byte[] AES_Encrypt(byte[] BytesToBeEncrypted, byte[] PasswordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] SaltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var Key = new Rfc2898DeriveBytes(PasswordBytes, SaltBytes, 1000);
                    AES.Key = Key.GetBytes(AES.KeySize / 8);
                    AES.IV = Key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var CS = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        CS.Write(BytesToBeEncrypted, 0, BytesToBeEncrypted.Length);
                        CS.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public byte[] AES_Decrypt(byte[] BytesToBeDecrypted, byte[] PasswordBytes)
        {
            byte[] DecryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] SaltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var Key = new Rfc2898DeriveBytes(PasswordBytes, SaltBytes, 1000);
                    AES.Key = Key.GetBytes(AES.KeySize / 8);
                    AES.IV = Key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var CS = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        CS.Write(BytesToBeDecrypted, 0, BytesToBeDecrypted.Length);
                        CS.Close();
                    }
                    DecryptedBytes = ms.ToArray();
                }
            }

            return DecryptedBytes;
        }

        public string EncryptText(string Input, string Password="MBPortal")
        {
            // Get the bytes of the string
            byte[] BytesToBeEncrypted = Encoding.UTF8.GetBytes(Input);
            byte[] PasswordBytes = Encoding.UTF8.GetBytes(Password);

            // Hash the Password with SHA256
            PasswordBytes = SHA256.Create().ComputeHash(PasswordBytes);

            byte[] BytesEncrypted = AES_Encrypt(BytesToBeEncrypted, PasswordBytes);

            string Result = Convert.ToBase64String(BytesEncrypted);

            return Result;
        }

        public string DecryptText(string Input, string Password="MBPortal")
        {
            // Get the bytes of the string
            byte[] BytesToBeDecrypted = Convert.FromBase64String(Input);
            byte[] PasswordBytes = Encoding.UTF8.GetBytes(Password);
            PasswordBytes = SHA256.Create().ComputeHash(PasswordBytes);

            byte[] bytesDecrypted = AES_Decrypt(BytesToBeDecrypted, PasswordBytes);

            string Result = Encoding.UTF8.GetString(bytesDecrypted);

            return Result;
        }
    }

}