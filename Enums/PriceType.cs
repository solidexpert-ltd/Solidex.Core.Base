namespace Solidex.Core.Data.EntityTypes
{
  /// <summary>
  /// The type of pricing
  /// </summary>
  public enum PriceType
  {
    /// <summary>
    /// the time is not recognized
    /// </summary>
    Undefined = 0,
    /// <summary>
    /// billed for each hour
    /// </summary>
    Hour = 1,
    /// <summary>
    /// 8 hours day
    /// </summary>
    Day = 8,
    /// <summary>
    /// working shift (12 hours)
    /// </summary>
    Shift = 12,
    /// <summary>
    /// 40 hours week
    /// </summary>
    BusinessWeek = 40,
    /// <summary>
    /// 56 housr week
    /// </summary>
    CalendarWeek = 56,
    /// <summary>
    /// 168 hours month
    /// </summary>
    WorkingMonth = 168,
    /// <summary>
    /// 248 housr month
    /// </summary>
    CalendarMonth = 248,
    /// <summary>
    /// fixed cost
    /// </summary>
    Fixed = 9999
  }
}