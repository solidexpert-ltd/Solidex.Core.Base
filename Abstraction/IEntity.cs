using System;

namespace Solidex.Core.Base.Abstraction
{
    /// <summary>
    /// General entity interface
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Unique id 
        /// </summary>
        Guid Id { get; set; }
        
        /// <summary>
        /// Created date
        /// </summary>
        DateTime CreatedDate { get; set; }
        
        /// <summary>
        /// Modified date 
        /// </summary>
        DateTime ModificationDate { get; set; }
    }
}