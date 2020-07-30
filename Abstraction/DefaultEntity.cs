using System;
using Solidex.Core.Base.Interfaces;

namespace Solidex.Core.Base.Abstraction
{
    public abstract class DefaultEntity : IEntity
    {
        protected DefaultEntity()
        {
            CreatedDate = DateTime.Now;
        }


        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}