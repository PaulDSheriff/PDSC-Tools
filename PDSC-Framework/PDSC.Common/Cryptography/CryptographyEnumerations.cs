namespace PDSC.Common.Cryptography
{
  public enum EncryptionHelperType : byte
  {
    DES,
    RC2,
    Rijndael,
    TripleDES
  }

  public enum HashHelperType : byte
  {
    MD5,
    SHA1,
    SHA256,
    SHA384,
    SHA512
  }
}
