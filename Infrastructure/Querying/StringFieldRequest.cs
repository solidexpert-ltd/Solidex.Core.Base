namespace Solidex.Core.Base.Infrastructure.Querying
{
    public class StringFieldRequest
    {
        /// <summary>
        /// Great then
        /// </summary>
        public string? Gt { get; set; }
        /// <summary>
        /// Great then or equals 
        /// </summary>
        public string? Gte { get; set; }
        /// <summary>
        /// Less then
        /// </summary>
        public string? Lt { get; set; }
        /// <summary>
        /// Equal
        /// </summary>
        public string? Eq { get; set; }
        
        /// <summary>
        /// In array
        /// </summary>
        public string[]? In { get; set; }
        
        /// <summary>
        /// Like fitering
        /// </summary>
        public string? Like { get; set; }
    }
}