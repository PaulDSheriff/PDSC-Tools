using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PDSC.Common.Cryptography
{
  /// <summary>
  /// This class is used to encrypt and decrypt a string.
  /// </summary>
  public class SymmetricHelper
  {
    public static Exception LastException { get; set; }

    #region Encrypt Methods
    /// <summary>
    /// Encrypt the value in the OriginalString property
    /// </summary>
    /// <returns>An encrypted string</returns>
    public static string Encrypt(EncryptionHelperType encType, string stringToEnc, string key, string iv)
    {
      SymmetricAlgorithm alg = GetEncryptor(encType);
      string ret = string.Empty;
      byte[] byt;

      alg.Key = Convert.FromBase64String(key);
      alg.IV = Convert.FromBase64String(iv);

      LastException = null;
      try {
        using (ICryptoTransform ct = alg.CreateEncryptor(alg.Key, alg.IV)) {
          byt = Encoding.UTF8.GetBytes(stringToEnc);

          using (MemoryStream ms = new()) {
            using (CryptoStream cs = new(ms, ct, CryptoStreamMode.Write)) {
              cs.Write(byt, 0, byt.Length);
              cs.FlushFinalBlock();

              ret = Convert.ToBase64String(ms.ToArray());
            };
          };
        };
      }
      catch (Exception ex) {
        LastException = ex;
      }

      return ret;
    }
    #endregion

    #region Decrypt Methods
    /// <summary>
    /// Decrypt the value in the EncryptedString property
    /// </summary>
    /// <returns>A decrypted string</returns>
    public static string Decrypt(EncryptionHelperType encType, string stringToEnc, string key, string iv)
    {
      SymmetricAlgorithm alg = GetEncryptor(encType);
      string ret = string.Empty;
      byte[] byt;

      alg.Key = Convert.FromBase64String(key);
      alg.IV = Convert.FromBase64String(iv);

      LastException = null;
      try {
        using (ICryptoTransform ct = alg.CreateDecryptor(alg.Key, alg.IV)) {
          byt = Convert.FromBase64String(stringToEnc);

          using (MemoryStream ms = new()) {
            using (CryptoStream cs = new(ms, ct, CryptoStreamMode.Write)) {
              cs.Write(byt, 0, byt.Length);
              cs.FlushFinalBlock();

              ret = Encoding.UTF8.GetString(ms.ToArray());
            };
          };
        };
      }
      catch (Exception ex) {
        LastException = ex;
      }

      return ret;
    }
    #endregion

    #region GetEncryptor Method
    public static SymmetricAlgorithm GetEncryptor(EncryptionHelperType encType)
    {
      SymmetricAlgorithm ret = null;

      switch (encType) {
        case EncryptionHelperType.DES:
          ret = new DESCryptoServiceProvider();
          break;
        case EncryptionHelperType.RC2:
          ret = new RC2CryptoServiceProvider();
          break;
        case EncryptionHelperType.Rijndael:
          ret = new RijndaelManaged();
          break;
        case EncryptionHelperType.TripleDES:
          ret = new TripleDESCryptoServiceProvider();
          break;
      }

      return ret;
    }
    #endregion

    #region GenerateKey Method
    /// <summary>
    /// Automatically generate a key to use for the encryption algorithm
    /// </summary>
    /// <returns>A key</returns>
    public static string GenerateKey(EncryptionHelperType encType)
    {
      SymmetricAlgorithm alg = GetEncryptor(encType);

      alg.GenerateKey();

      return Convert.ToBase64String(alg.Key);
    }
    #endregion

    #region GenerateIV Method
    /// <summary>
    /// Automatically generate a IV to use for the encryption algorithm
    /// </summary>
    /// <returns>A IV</returns>
    public static string GenerateIV(EncryptionHelperType encType)
    {
      SymmetricAlgorithm alg = GetEncryptor(encType);

      alg.GenerateIV();

      return Convert.ToBase64String(alg.IV);
    }
    #endregion
  }
}
