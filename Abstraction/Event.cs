using System;

namespace Solidex.Core.Base.Abstraction
{
    public abstract class Event: IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificationDate { get; set; }
        
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}