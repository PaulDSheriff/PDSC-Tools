using System;
using System.Collections.Generic;
using System.Linq;
using PDSC.Common.DataLayer;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.ViewModelLayer
{
  public partial class PrivacyPolicyViewModel
  {
    #region GetLatest Method
    public virtual void GetLatest()
    {
      if (Repository == null) {
        throw new ApplicationException("Must set the Repository property.");
      }
      else {
        // Get latest terms and agreements
        SelectedEntity = ((PrivacyPolicyRepository)Repository).GetLatest();
      }
    }
    #endregion
  }
}
