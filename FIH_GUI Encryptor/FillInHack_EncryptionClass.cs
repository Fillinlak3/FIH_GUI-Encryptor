using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace FIH_GUI_Encryptor
{
    public class FillInHack : Main_Form
    {
        private const string _Encryption_Key = ".[]n>qh*Z|g4vJf*\"/\"N>[c*\\W\'O4zH#";
        private const string _Encryption_Private_Self_Key = "@>_{[FIH]}_F1!#i2/l3l$4I5\'.n!6\\H7^a8c~9&k0*`]/?_<#";
        private const string _Encryption_IV = "n0&y)$MGjBt24?L8";

        // AES-256 bit Encryption
        public void Encrypt(Stream inputStream, Stream outputStream, string key)
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
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                {
                    while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        cryptoStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }

        public void Decrypt(Stream inputStream, Stream outputStream, string key)
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
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                {
                    while ((bytesRead = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }

        // MD5 Encryption
        public string MD5_Encrypt(string _Text, string _Hash)
        {
            byte[] data = System.Text.UTF8Encoding.UTF8.GetBytes(_Text);
            using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] key_hash = md5.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(_Hash));
                using (System.Security.Cryptography.TripleDESCryptoServiceProvider triple_des = new System.Security.Cryptography.TripleDESCryptoServiceProvider() { Key = key_hash, Mode = System.Security.Cryptography.CipherMode.ECB, Padding = System.Security.Cryptography.PaddingMode.PKCS7 })
                {
                    System.Security.Cryptography.ICryptoTransform transform = triple_des.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return System.Convert.ToBase64String(result, 0, result.Length);
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
            byte[] data = System.Convert.FromBase64String(_Text);
            using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] key_hash = md5.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(_Hash));
                using (System.Security.Cryptography.TripleDESCryptoServiceProvider triple_des = new System.Security.Cryptography.TripleDESCryptoServiceProvider() { Key = key_hash, Mode = System.Security.Cryptography.CipherMode.ECB, Padding = System.Security.Cryptography.PaddingMode.PKCS7 })
                {
                    System.Security.Cryptography.ICryptoTransform transform = triple_des.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return System.Text.UTF8Encoding.UTF8.GetString(result);
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
    }
}
