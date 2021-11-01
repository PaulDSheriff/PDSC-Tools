using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PDSC.Common
{
  /// <summary>
  /// This class allows you to query Assembly information about your currently executing assembly.
  /// </summary>
  public class AssemblyInfo
  {
    //  Used by Helper Functions to access information from Assembly Attributes
    private readonly Assembly _CurrentAssm;

    #region Constructors
    /// <summary>
    /// Base constructor of the CSAssemblyInfo. Gets a reference to the CallingAssembly.
    /// </summary>
    public AssemblyInfo()
    {
      _CurrentAssm = Assembly.GetCallingAssembly();
    }

    /// <summary>
    /// Base constructor of the CSAssemblyInfo.
    /// </summary>
    /// <param name="assm">An assembly to get info from</param>
    public AssemblyInfo(Assembly assm)
    {
      _CurrentAssm = assm;
    }
    #endregion
        
    /// <summary>
    /// Gets the Copyright property from the Assembly
    /// </summary>
    public string Copyright
    {
      get
      {
        Type at = typeof(AssemblyCopyrightAttribute);
        object[] r = _CurrentAssm.GetCustomAttributes(at, false);
        AssemblyCopyrightAttribute ct = ((AssemblyCopyrightAttribute)(r[0]));
        return ct.Copyright;
      }
    }

    /// <summary>
    /// Gets the Company property from the Assembly
    /// </summary>
    public string Company
    {
      get
      {
        Type at = typeof(AssemblyCompanyAttribute);
        object[] r = _CurrentAssm.GetCustomAttributes(at, false);
        AssemblyCompanyAttribute ct = ((AssemblyCompanyAttribute)(r[0]));
        return ct.Company;
      }
    }

    /// <summary>
    /// Gets the Description property from the Assembly
    /// </summary>
    public string Description
    {
      get
      {
        Type at = typeof(AssemblyDescriptionAttribute);
        object[] r = _CurrentAssm.GetCustomAttributes(at, false);
        AssemblyDescriptionAttribute da = ((AssemblyDescriptionAttribute)(r[0]));
        return da.Description;
      }
    }

    /// <summary>
    /// Gets the Product property from the Assembly
    /// </summary>
    public string Product
    {
      get
      {
        Type at = typeof(AssemblyProductAttribute);
        object[] r = _CurrentAssm.GetCustomAttributes(at, false);
        AssemblyProductAttribute pt = ((AssemblyProductAttribute)(r[0]));
        return pt.Product;
      }
    }

    /// <summary>
    /// Gets the Title property from the Assembly
    /// </summary>
    public string Title
    {
      get
      {
        Type at = typeof(AssemblyTitleAttribute);
        object[] r = _CurrentAssm.GetCustomAttributes(at, false);
        AssemblyTitleAttribute ta = ((AssemblyTitleAttribute)(r[0]));
        return ta.Title;
      }
    }

    /// <summary>
    /// Gets the Guid property from the Assembly
    /// </summary>
    public string AssemblyGuid
    {
      get
      {
        string ret = string.Empty;

        object[] at = _CurrentAssm.GetCustomAttributes(typeof(GuidAttribute), false);
        if (at.Length > 0)
        {
          ret = ((GuidAttribute)at[0]).Value;
        }

        return ret;
      }
    }

    /// <summary>
    /// Gets the Version property from the Assembly
    /// </summary>
    public string Version
    {
      get { return _CurrentAssm.GetName().Version.ToString(); }
    }
  }
}
