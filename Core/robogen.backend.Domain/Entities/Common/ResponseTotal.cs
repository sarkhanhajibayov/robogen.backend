namespace robogen.backend.Domain.Entities.Common
{
    public class ResponseTotal<T>
    {
        public List<T> Data { get; set; }
        public decimal Total { get; set; }
    }
}
