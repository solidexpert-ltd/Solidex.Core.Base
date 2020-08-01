namespace  Solidex.Core.Base.Infrastructure.Querying
{
    public class FilterRequest<T>: FilterRequest
    {
        public T Selector { get; set; }

        public override int Limit { get; set; } = 30;
    }

    public class FilterRequest
    {
        public int Page { get; set; } = 1;
        public virtual int Limit { get; set; }
        public string[] Sort { get; set; }
        public string[] SortValue { get; set; }
    }
}