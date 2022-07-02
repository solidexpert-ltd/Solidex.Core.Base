using System;
using System.Collections.Generic;
using Solidex.Core.Base.Abstraction;

namespace Solidex.Core.Base.Localization;

/// <summary>
/// Translation Field
/// </summary>
public class Field : IEntity
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
    /// English name of field
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// field index
    /// </summary>
    public int Index { get; set; }
    
    /// <summary>
    /// Reference to object 
    /// </summary>
    public Guid ObjectId { get; set; }
    
    /// <summary>
    /// List of translations.
    /// </summary>
    public List<Translation> Translations { get; set; }
}