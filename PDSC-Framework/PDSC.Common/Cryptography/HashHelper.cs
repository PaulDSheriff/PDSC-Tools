using System;
using System.Security.Cryptography;
using System.Text;

namespace PDSC.Common.Cryptography
{
  /// <summary>
  /// This class is used to hash a string
  /// </summary>
  public class HashHelper
  {
    public const string DEFAULT_SALT = "A!b9(d)32";
    public static Exception LastException { get; set; }

    public static string GenerateSalt()
    {
      string ret = DEFAULT_SALT;
      byte[] bytSalt = new byte[8];
      RNGCryptoServiceProvider rng;

      LastException = null;
      try {
        rng = new RNGCryptoServiceProvider();

        rng.GetBytes(bytSalt);

        ret = Convert.ToBase64String(bytSalt);
      }
      catch (Exception ex) {
        LastException = ex;
      }

      return ret;
    }

    #region GetHashAlgorithm() Method
    private static HashAlgorithm GetHashAlgorithm(HashHelperType hashType)
    {
      HashAlgorithm ret = null;

      switch (hashType) {
        case HashHelperType.MD5:
          ret = new MD5CryptoServiceProvider();
          break;
        case HashHelperType.SHA1:
          ret = new SHA1CryptoServiceProvider();
          break;
        case HashHelperType.SHA256:
          ret = new SHA256Managed();
          break;
        case HashHelperType.SHA384:
          ret = new SHA384Managed();
          break;
        case HashHelperType.SHA512:
          ret = new SHA512Managed();
          break;
      }

      return ret;
    }
    #endregion

    #region Hash Methods
    public static string Hash(HashHelperType hashType, string stringToHash)
    {
      return Hash(hashType, stringToHash, string.Empty);
    }

    public static string Hash(HashHelperType hashType, string stringToHash, string saltValue)
    {
      HashAlgorithm alg = null;
      string ret = string.Empty;
      byte[] bytValue;
      byte[] bytHash;

      if (string.IsNullOrEmpty(stringToHash)) {
        throw new ArgumentNullException("stringToHash", "The string to hash must not be null.");
      }

      LastException = null;
      try {
        // Make sure it is not null
        saltValue ??= string.Empty;

        // Create Hash Algorithm Object
        alg = GetHashAlgorithm(hashType);

        // Convert the original string to array of bytes
        bytValue = Encoding.UTF8.GetBytes(saltValue + stringToHash);

        // Compute the hash, returns an array of bytes  
        bytHash = alg.ComputeHash(bytValue);

        // Return a base 64 encoded string of the hash value
        ret = Convert.ToBase64String(bytHash);
      }
      catch (Exception ex) {
        LastException = ex;
      }
      finally {
        if (alg != null) {
          alg.Dispose();
        }
      }

      return ret;
    }
    #endregion
  }
}
