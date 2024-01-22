using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace FIH_GUI_Encryptor
{
    public class FillInHack
    {
        private const string _Encryption_Key = ".[]n>qh*Z|g4vJf*\"/\"N>[c*\\W\'O4zH#";
        private const string _Encryption_Private_Self_Key = "@>_{[FIH]}_F1!#i2/l3l$4I5\'.n!6\\H7^a8c~9&k0*`]/?_<#";
        private const string _Encryption_IV = "n0&y)$MGjBt24?L8";

        // AES-256 bit Encryption
        public async Task Encrypt(Stream inputStream, Stream outputStream, string key, IProgress<int> progress)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                var keyBytes = new byte[32];
                var keyArray = Encoding.UTF8.GetBytes(key);
                Array.Copy(keyArray, keyBytes, Math.Min(keyBytes.Length, keyArray.Length));
                aes.Key = keyBytes;

                aes.GenerateIV();

                // Write IV to the output stream
                outputStream.Write(aes.IV, 0, 16);

                // Process the file in chunks
                byte[] buffer = new byte[4096];
                int bytesRead;
                long totalBytesRead = 0;
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                {
                    while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        await cryptoStream.WriteAsync(buffer, 0, bytesRead);

                        totalBytesRead += bytesRead;
                        // Report progress
                        if (progress != null)
                        {
                            int percentage = (int)((totalBytesRead * 100) / inputStream.Length / 2);
                            progress.Report(percentage);
                        }
                    }
                }
                keyBytes = null;
                keyArray = null;
                buffer = null;
            }
        }
        public async Task DoubleEncrypt(Stream inputStream, Stream outputStream, string privatekey, string publickey, int bufferSize = 81920)
        {
            // Create a temporary file for the first encryption
            string tempFile = Path.GetTempFileName();
            int percentageFirst = 0;
            IProgress<int> progress = new Progress<int>(percentage =>
            {
                // Update your progress bar with the 'percentage' value
                Main_Form.EncryptionProgress.Value = percentageFirst + percentage;
            });

            try
            {
                // First encryption with private key.
                using (FileStream tempStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize, FileOptions.Asynchronous | FileOptions.SequentialScan))
                {
                    await Encrypt(inputStream, tempStream, privatekey, progress);
                    percentageFirst = Main_Form.DecryptionProgress.Value;
                }

                // Second encryption with public key.
                using (FileStream tempStream = new FileStream(tempFile, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize, FileOptions.Asynchronous | FileOptions.SequentialScan))
                {
                    await Encrypt(tempStream, outputStream, publickey, progress);
                }
            }
            finally
            {
                // Delete the temporary file
                File.Delete(tempFile);
            }
        }

        public async Task Decrypt(Stream inputStream, Stream outputStream, string key, IProgress<int> progress)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                var keyBytes = new byte[32];
                var keyArray = Encoding.UTF8.GetBytes(key);
                Array.Copy(keyArray, keyBytes, Math.Min(keyBytes.Length, keyArray.Length));
                aes.Key = keyBytes;

                // Read IV from the input stream
                byte[] iv = new byte[16];
                inputStream.Read(iv, 0, 16);
                aes.IV = iv;

                // Process the file in chunks
                byte[] buffer = new byte[4096];
                int bytesRead;
                long totalBytesRead = 0;
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                {
                    while ((bytesRead = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        await outputStream.WriteAsync(buffer, 0, bytesRead);

                        totalBytesRead += bytesRead;
                        // Report progress
                        if (progress != null)
                        {
                            int percentage = (int)((totalBytesRead * 100) / inputStream.Length / 2);
                            progress.Report(percentage);
                        }
                    }
                }
                keyBytes = null;
                keyArray = null;
                iv = null;
                buffer = null;
            }
        }
        public async Task DoubleDecrypt(Stream inputStream, Stream outputStream, string privatekey, string publickey, int bufferSize = 81920)
        {
            // Create a temporary file for the first decryption
            string tempFile = Path.GetTempFileName();
            int percentageFirst = 0;
            IProgress<int> progress = new Progress<int>(percentage =>
            {
                // Update your progress bar with the 'percentage' value
                Main_Form.DecryptionProgress.Value = percentageFirst + percentage;
            });

            try
            {
                // First encryption with private key.
                using (FileStream tempStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize, FileOptions.Asynchronous | FileOptions.SequentialScan))
                {
                    await Decrypt(inputStream, tempStream, publickey, progress);
                    percentageFirst = Main_Form.DecryptionProgress.Value;
                }

                // Second encryption with public key.
                using (FileStream tempStream = new FileStream(tempFile, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize, FileOptions.Asynchronous | FileOptions.SequentialScan))
                {
                    try
                    {
                        await Decrypt(tempStream, outputStream, privatekey, progress);
                    }
                    catch
                    {
                        throw new Exception("This file was encrypted under the authorization of another user. Access is totally confidential and forbidden.");
                    }
                }
            }
            finally
            {
                // Delete the temporary file
                File.Delete(tempFile);
            }
        }

        // Key Generation
        public string Generate_Key(int length = 32)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890`~!@#$%^&*()-_=+[{]};:\'\"\\|,<.>/?";
            string key = string.Empty;
            System.Random random = new System.Random();
            for (int i = 0; i < length; i++)
                key += chars[random.Next(0, 94)];

            return key;
        }

        // MD5 Encryption
        public string MD5_Encrypt(string _Text, string _Hash)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(_Text);
            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] key_hash = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_Hash));
                using (var triple_des = new TripleDESCryptoServiceProvider() { Key = key_hash, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = triple_des.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }
        private void MD5_GenerateKey(int _times)
        {
            Main_Form.Generated_Key = string.Empty;
            for (int i = 0; i < _times; i++)
                Main_Form.Generated_Key += Generate_Key();
        }
        public string MD5_EncryptMultipleTimes(string _Text, int _times)
        {
            if (String.IsNullOrEmpty(Main_Form.Generated_Key))
                MD5_GenerateKey(_times);

            string _Key;
            for (int i = 0; i < _times; i++)
            {
                _Key = Main_Form.Generated_Key.Substring(i * 100, 100);
                _Text = MD5_Encrypt(_Text, _Key);
            }

            //_Text = MD5_Encrypt(_Text, _Encryption_Key);
            //_Text = MD5_Encrypt(_Text, _Encryption_IV);
            _Text = MD5_Encrypt(_Text, _Encryption_Private_Self_Key);
            _Text = "FillInHack!" + _Text;

            System.GC.Collect();
            return _Text;
        }
        public string MD5_Decrypt(string _Text, string _Hash)
        {
            byte[] data = Convert.FromBase64String(_Text);
            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] key_hash = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_Hash));
                using (var triple_des = new TripleDESCryptoServiceProvider() { Key = key_hash, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = triple_des.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(result);
                }
            }
        }
        public string MD5_DecryptMultipleTimes(string _Text, int _times)
        {
            _Text = MD5_Decrypt(_Text, _Encryption_Private_Self_Key);
            //_Text = MD5_Decrypt(_Text, _Encryption_IV);
            //_Text = MD5_Decrypt(_Text, _Encryption_Key);

            string temp_key;
            for (int i = _times - 1; i >= 0; i--)
            {
                temp_key = Main_Form.Generated_Key.Substring(i * 100, 100);
                _Text = MD5_Decrypt(_Text, temp_key);
            }

            System.GC.Collect();
            return _Text;
        }
    }
}
