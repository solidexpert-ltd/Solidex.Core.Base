using System;
using Solidex.Core.Base.Abstraction;

namespace Solidex.Core.Base.Localization;

/// <summary>
/// The localized entity
/// </summary>
public interface ILocalizedEntity : IEntity
{
    /// <summary>
    /// The reference id
    /// </summary>
    public Guid EntityId { get; set; }
    
    /// <summary>
    /// The current locale 
    /// </summary>
    public string Locale { get; set; }
}