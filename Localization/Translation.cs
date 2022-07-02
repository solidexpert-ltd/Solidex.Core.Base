using System;
using Solidex.Core.Base.Abstraction;

namespace Solidex.Core.Base.Localization;

/// <summary>
/// Provide single class to translate all dynamic data
/// </summary>
public class Translation : IEntity
{
    #region IEntity

    /// <inheritdoc />
    public Guid Id { get; set; }

    /// <inheritdoc />
    public DateTime CreatedDate { get; set; }

    /// <inheritdoc />
    public DateTime ModificationDate { get; set; }

    #endregion
    
    /// <summary>
    /// Link to field
    /// </summary>
    public Guid FieldId { get; set; }
    
    /// <summary>
    /// Actual Language code
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// real value of language 
    /// </summary>
    public string Value { get; set; }
}