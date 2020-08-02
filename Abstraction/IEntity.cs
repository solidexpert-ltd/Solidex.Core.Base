using System;

namespace Solidex.Core.Base.Abstraction
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModificationDate { get; set; }
    }
}