using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;

namespace FIH_GUI_Encryptor
{
    public class FillInHack : Main_Form
    {
        private const string _Encryption_Key = ".[]n>qh*Z|g4vJf*\"/\"N>[c*\\W\'O4zH#";
        private const string _Encryption_Private_Self_Key = "@>_{[FIH]}_F1!#i2/l3l$4I5\'.n!6\\H7^a8c~9&k0*`]/?_<#";
        private const string _Encryption_IV = "n0&y)$MGjBt24?L8";

        // AES-256 bit Encryption
        public string Encrypt(string message, string KeyString)
        {
            byte[] Key = ASCIIEncoding.UTF8.GetBytes(KeyString);
            string encrypted = null;

            using (var rijndaelManaged =
                       new RijndaelManaged { Key = Key, Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7, BlockSize = 128, KeySize = 256 })
            {
                rijndaelManaged.GenerateIV();
                try
                {
                    // Get the generated IV.
                    byte[] iv = rijndaelManaged.IV;

                    using (var memoryStream = new MemoryStream())
                    {
                        using (var cryptoStream =
                               new CryptoStream(memoryStream,
                                   rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV),
                                   CryptoStreamMode.Write))
                        using (var streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(message);
                        }

                        // Combine IV and ciphertext.
                        Debug.WriteLine("1");
                        byte[] combined = new byte[iv.Length + memoryStream.Length];
                        Debug.WriteLine("2");
                        Array.Copy(iv, 0, combined, 0, iv.Length);
                        Debug.WriteLine("3");
                        memoryStream.ToArray().CopyTo(combined, iv.Length);
                        Debug.WriteLine("4");
                        // IV + message encoded.
                        encrypted = Convert.ToBase64String(combined);
                        Debug.WriteLine("5");
                    }
                }
                catch (CryptographicException e)
                {
                    Debug.WriteLine($"[FIH Class - Encrypt] -> A Cryptographic error occurred: {e.Message}");
                    return null;
                }
                catch (UnauthorizedAccessException e)
                {
                    Debug.WriteLine($"[FIH Class - Encrypt] -> A file error occurred: {e.Message}");
                    return null;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"[FIH Class - Encrypt] -> An error occurred: {e.Message}");
                }
            }

            return encrypted;
        }
        public string Decrypt(string cipherData, string keyString)
        {
            byte[] key = Encoding.UTF8.GetBytes(keyString);
            byte[] combined = Convert.FromBase64String(cipherData);
            byte[] iv = new byte[16];
            byte[] ciphertext = new byte[combined.Length - iv.Length];

            Array.Copy(combined, 0, iv, 0, iv.Length);
            Array.Copy(combined, iv.Length, ciphertext, 0, ciphertext.Length);

            try
            {
                using (var rijndaelManaged =
                       new RijndaelManaged { Key = key, IV = iv, Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7, BlockSize = 128, KeySize = 256 })
                using (var memoryStream =
                       new MemoryStream(Convert.FromBase64String(cipherData)))
                using (var cryptoStream =
                       new CryptoStream(memoryStream,
                           rijndaelManaged.CreateDecryptor(key, iv),
                           CryptoStreamMode.Read))
                {
                    return new StreamReader(cryptoStream).ReadToEnd();
                }
            }
            catch (CryptographicException e)
            {
                Debug.WriteLine($"[FIH Class - Decrypt] -> A Cryptographic error occurred: {e.Message}");
                return null;
            }
            // You may want to catch more exceptions here...
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
