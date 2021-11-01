using System;
using System.Security;
using System.Text;

namespace PDSC.Common
{
  /// <summary>
  /// Use this class to set user information
  /// </summary>
  public class UserEntity : EntityBase
  {
    #region Public Properties
    /// <summary>
    /// Get/Set a numeric user Id
    /// </summary>
    public int? UserId { get; set; }
    /// <summary>
    /// Get/Set a GUID user id
    /// </summary>
    public Guid? UserIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string EmailAddress2 { get; set; }
    public string LoginName { get; set; }
    public string DisplayName { get; set; }
    public string Password { get; set; }
    public SecureString UserPassword { get; set; }
    public string UserLanguage { get; set; }
    public string SecurityQuestion { get; set; }
    public string SecurityAnswer { get; set; }
    public DateTime? LastLoginDate { get; set; }
    public bool IsLockedOut { get; set; }
    public bool IsActive { get; set; }
    public bool IsLoggedIn { get; set; }
    public bool ResetPasswordFlag { get; set; }
    public DateTime? LastPasswordResetDate { get; set; }
    #endregion

    #region Init Method
    public override void Init()
    {
      base.Init();

      LoginName = PDSCConstants.DEFAULT_LOGIN_NAME;
      UserLanguage = PDSCConstants.DEFAULT_LANGUAGE;
    }
    #endregion

    #region ToString Override
    /// <summary>
    /// Returns all properties of this class in one large string
    /// </summary>
    /// <returns>User Information</returns>
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      if (UserIdentifier.HasValue) {
        sb.AppendLine("User Identifier: " + UserIdentifier.Value.ToString());
      }
      if (UserId.HasValue) {
        sb.AppendLine("User ID: " + UserId.Value.ToString());
      }
      if (!string.IsNullOrEmpty(LoginName)) {
        sb.AppendLine("Login Name: " + LoginName);
      }
      if (!string.IsNullOrEmpty(FirstName)) {
        sb.AppendLine("First Name: " + FirstName);
      }
      if (!string.IsNullOrEmpty(LastName)) {
        sb.AppendLine("Last Name: " + LastName);
      }

      return sb.ToString();
    }
    #endregion
  }
}
