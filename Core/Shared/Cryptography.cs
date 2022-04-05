using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Core.Shared {
    public class Cryptography {
        public class Hash {
            public static string getHash(string rawData) {
                using (SHA256 sha256Hash = SHA256.Create()) {
                    // ComputeHash - returns byte array  
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                    // Convert byte array to a string   
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++) {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            public static string MD5Checksum(string str) {
                string hash;
                using (MD5 md5 = MD5.Create()) {
                    hash = BitConverter.ToString(
                      md5.ComputeHash(Encoding.UTF8.GetBytes(str))
                    ).Replace("-", String.Empty);
                }
                return hash;
            }
        }
        public class AES {
            public RijndaelManaged GetRijndaelManaged(String secretKey) {
                var keyBytes = new byte[16];
                var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
                Array.Copy(secretKeyBytes, keyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length));
                return new RijndaelManaged {
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7,
                    KeySize = 128,
                    BlockSize = 128,
                    Key = keyBytes,
                    IV = keyBytes
                };
            }

            private byte[] Encrypt(byte[] plainBytes, RijndaelManaged rijndaelManaged) {
                return rijndaelManaged.CreateEncryptor()
                    .TransformFinalBlock(plainBytes, 0, plainBytes.Length);
            }

            private byte[] Decrypt(byte[] encryptedData, RijndaelManaged rijndaelManaged) {
                return rijndaelManaged.CreateDecryptor()
                    .TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            }

            public string Encrypt(string plainText, string key) {
                try {
                    var plainBytes = Encoding.UTF8.GetBytes(plainText);
                    return Convert.ToBase64String(Encrypt(plainBytes, GetRijndaelManaged(key)));
                } catch {
                    return null;
                }
            }

            public string Encrypt(object obj, string key) {
                try {
                    string plainText = JObject.FromObject(obj).ToString();
                    var plainBytes = Encoding.UTF8.GetBytes(plainText);
                    return Convert.ToBase64String(Encrypt(plainBytes, GetRijndaelManaged(key)));
                } catch {
                    return null;
                }
            }

            public string Decrypt(string encryptedText, string key) {
                try {
                    var encryptedBytes = Convert.FromBase64String(encryptedText);
                    return Encoding.UTF8.GetString(Decrypt(encryptedBytes, GetRijndaelManaged(key)));
                } catch {
                    return null;
                }
            }
        }
        public class CharGenerator {
            private static readonly List<string> templates = new List<string> { "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ", "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", "1234567890", "1234567890abcdef", "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "abcdefghijklmnopqrstuvwxyz" };
            public static string genID(int counts, characterSet type = 0) {
                char[] generated = new char[counts];
                char[] characters = templates[(int)type].ToCharArray();
                var random = new Random();
                int sampleLength = characters.Length - 1;
                for (int i = 0; i < counts; i++) {
                    int index = random.Next(0, sampleLength);
                    generated[i] = characters[index];
                }
                return new string(generated);
            }

            public static string genID() {
                Guid id = Guid.NewGuid();
                return id.ToString();
            }

            public enum characterSet {
                NUMERIC = 2,
                ALPHA_NUMERIC_NON_CASE = 0,
                ALPHA_NUMERIC_CASE = 1,
                HEX_STRING = 3,
                GUID = 6,
                UPPER_ALPHABETS_ONLY = 4,
                LOWER_ALPHABETS_ONLY = 5
            }
        }
    }
}
