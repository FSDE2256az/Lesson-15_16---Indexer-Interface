namespace Indexer_Record._1.Indexer;

public class BusinessException : ApplicationException
{
    public string Message { get; set; }

    public BusinessException(string message) : base(message)
    {
    }
}
