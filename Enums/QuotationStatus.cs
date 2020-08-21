namespace Solidex.Core.Base.Enums
{
  /// <summary>
  /// Enum describe current status of quotation
  /// </summary> 
  public enum QuotationStatus
  {
    /// <summary>
    /// created quotation
    /// </summary>
    New = 0,
    /// <summary>
    /// ReOpened quotation
    /// </summary>
    Opened = 10,
    /// <summary>
    /// quotation has ac
    /// </summary>
    Holded = 20,
    /// <summary>
    /// Quotation Accepted by user
    /// </summary>
    Accepted = 30,
    /// <summary>
    /// Quotatioon canceled
    /// </summary>
    Canceled = 40
  }
}