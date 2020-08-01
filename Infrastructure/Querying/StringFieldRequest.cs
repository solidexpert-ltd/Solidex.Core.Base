namespace Solidex.Core.Base.Infrastructure.Querying
{
    public class StringFieldRequest
    {
        /// <summary>
        /// Great then
        /// </summary>
        public string Gt { get; set; }
        public string Gte { get; set; }
        /// <summary>
        /// Less then
        /// </summary>
        public string Lt { get; set; }
        /// <summary>
        /// Equal
        /// </summary>
        public string Eq { get; set; }
        public string[] In { get; set; }
    }
}