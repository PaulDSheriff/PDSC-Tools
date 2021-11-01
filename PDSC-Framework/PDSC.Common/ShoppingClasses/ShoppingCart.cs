using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PDSC.Common.Shopping
{
  /// <summary>
  /// This class holds all products in the shopping cart
  /// </summary>
  public partial class ShoppingCart
  {
    public ShoppingCart()
    {
      DateCreated = DateTime.Now;
      Items = new List<ShoppingCartItem>();
      PromotionCode = new PromoCode();
    }

    private const int MINUTES_TO_EXPIRE = 1;

    /// <summary>
    /// Get/Set the date/time this shopping cart was created
    /// </summary>
    private DateTime _DateCreated;

    public DateTime DateCreated
    {
      get { return _DateCreated; }
      set {
        _DateCreated = value;
        DateExpires = _DateCreated.AddMinutes(MINUTES_TO_EXPIRE);
      }
    }

    /// <summary>
    /// Get/Set the date/time until this cart expires
    /// </summary>
    public DateTime DateExpires { get; set; }

    /// <summary>
    /// Get minutes/seconds until cart expires
    /// </summary>
    public string CartExpirationMessage
    {
      get {
        TimeSpan span = (DateExpires - DateTime.Now);

        return $"Your cart expires in {span.Minutes} minute(s) and {span.Seconds} second(s)";
      }
    }

    /// <summary>
    /// Get/Set the list of items in the shopping cart
    /// </summary>
    public List<ShoppingCartItem> Items { get; set; }

    /// <summary>
    /// Get the total $ amount for all items in the cart
    /// </summary>
    [DataType(DataType.Currency)]
    public decimal TotalCart
    {
      get {
        return Items.Sum(c => c.TotalPrice);
      }
    }

    /// <summary>
    /// Get/Set the PromoCode value
    /// </summary>
    public PromoCode PromotionCode { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{DateCreated}";
    }
    #endregion
  }
}
