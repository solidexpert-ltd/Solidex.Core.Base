namespace Solidex.Core.Base.Responses;

/// <summary>
/// Interface of response
/// </summary>
public interface IResponse
{
    /// <summary>
    /// Return Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Status code
    /// </summary>
    public int StatusCode { get; set; }
}