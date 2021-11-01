using System.Collections.Generic;
using System.Linq;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class SiteTermsRepository
  {
    #region GetLatest Method
    public SiteTerms GetLatest()
    {
      return _DbContext.SiteTerms.Where(e => e.IsActive).OrderByDescending(e => e.InsertDate).Take(1).ToList()[0];
    }
    #endregion
  }
}
