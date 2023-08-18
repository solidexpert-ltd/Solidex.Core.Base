namespace  Solidex.Core.Base.Infrastructure.Querying
{
    public class FilterRequest<T>: FilterRequest
    {
        /// <summary>
        /// The selector of field
        /// </summary>
        public T Selector { get; set; }

        /// <summary>
        /// The limit of items
        /// </summary>
        public override int Limit { get; set; } = 30;
    }

    public class FilterRequest
    {
        /// <summary>
        /// The page of request
        /// </summary>
        public int Page { get; set; } = 1;
        
        /// <summary>
        /// The limit of items
        /// </summary>
        public virtual int Limit { get; set; }
    
        /// <summary>
        /// The list of sorting 
        /// </summary>
        public string[] Sort { get; set; }
        
        /// <summary>
        /// The list of sorting values
        /// </summary>
        public string[] SortValue { get; set; }
    }
}