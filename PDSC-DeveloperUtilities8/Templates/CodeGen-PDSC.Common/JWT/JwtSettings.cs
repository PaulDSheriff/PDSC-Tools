namespace PDSC.Common.JWT;

public class JwtSettings
{
  public JwtSettings()
  {
    Key = "A_KEY_GOES_HERE";
    Issuer = "http://localhost:nnnn";
    Audience = "Audience";
    MinutesToExpiration = 1;
    AllowedIPAddresses = Array.Empty<string>();
  }

  public string Key { get; set; }
  public string Issuer { get; set; }
  public string Audience { get; set; }
  public int MinutesToExpiration { get; set; }
  public string[] AllowedIPAddresses { get; set; }
}
