using System.ComponentModel.DataAnnotations;

namespace PDSC.Common.ViewModelLayer
{
  public partial class UnsubscribeViewModel : ViewModelBase
  {
    #region Constructors
    /// <summary>
    ///  NOTE: You need to have a parameterless constructor for Post-Backs in MVC    
    /// </summary>
    public UnsubscribeViewModel() : base()
    {

    }
    #endregion

    #region Properties
    [EmailAddress]
    [Required(ErrorMessage = "Email must be filled in.")]
    public string EmailAddress { get; set; }
    #endregion

    #region Init Method
    public override void Init()
    {
      base.Init();
    }
    #endregion

    #region Unsubscribe Method
    public void Unsubscribe()
    {
      // TODO: Unsubscribe
    
      IsValid = true;
    }
    #endregion
  }
}