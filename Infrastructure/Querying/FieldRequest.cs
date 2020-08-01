namespace  Solidex.Core.Base.Infrastructure.Querying
{
    public class FieldRequest<T> where T : struct
    {
        /// <summary>
        /// Great then
        /// </summary>
        public T? Gt { get; set; }
        /// <summary>
        /// Less then
        /// </summary>
        public T? Lt { get; set; }
        /// <summary>
        /// Equal
        /// </summary>
        public T? Eq { get; set; }
        public T[] In { get; set; }
    }
}