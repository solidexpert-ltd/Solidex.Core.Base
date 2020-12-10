using System;

namespace Solidex.Core.Base.Abstraction
{
    public abstract class Calendar: IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificationDate { get; set; }
        
        public string Color { get; set; }
        
        public abstract string GetName();
        public abstract string GetRouteName();
        public abstract string GetCalendarType();
        
        //public virtual ICollection<Event> Events { get; set; }
    }
}