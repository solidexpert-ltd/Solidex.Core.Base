using System;

namespace Solidex.Core.Base.Abstraction
{
    public interface ICalendarViewModel
    {
        Guid CalendarId { get; set; }
        string Title { get; set; }
        string TeaserImage { get; set; }
        string Color { get; set; }
    }
}