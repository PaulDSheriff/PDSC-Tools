using System;
using System.Collections.Generic;
using System.Linq;
using PDSC.Common.DataLayer;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.ViewModelLayer
{
  public partial class ContactUsViewModel
  {  
    #region IsDuplicateReport Method
    public virtual bool IsDuplicateReport()
    {
      return ((ContactUsRepository)Repository).IsDuplicateReport(SelectedEntity);
    }
    #endregion

    #region SendEmail Method
    public virtual bool SendEmail()
    {
      return true;
    }
    #endregion
  }
}
