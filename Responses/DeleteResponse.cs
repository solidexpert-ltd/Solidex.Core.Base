using System;

namespace Solidex.Core.Base.Responses;

/// <summary>
/// Standard response of deletion operation
/// </summary>
public class DeleteResponse: IResponse
{
    /// <summary>
    /// Return Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Status code
    /// </summary>
    public int StatusCode { get; set; }

    /// <summary>
    /// Id of deleted object
    /// </summary>
    public Guid Id { get; set; }
}