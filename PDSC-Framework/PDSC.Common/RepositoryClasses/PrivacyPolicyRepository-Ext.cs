using System.Linq;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class PrivacyPolicyRepository
  {
    #region GetLatest Method
    public PrivacyPolicy GetLatest()
    {
      return _DbContext.PrivacyPolicies.Where(e => e.IsActive).OrderByDescending(e => e.InsertDate).Take(1).ToList()[0];
    }
    #endregion
  }
}
