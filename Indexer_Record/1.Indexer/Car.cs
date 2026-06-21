namespace Indexer_Record._1.Indexer;

public class Car
{
    public Guid Id { get; set; }
    public string? Make { get; set; }
    public string Model { get; set; }
    public DateTime CreatedDate { get; set; }


    public override string ToString()
    => $@"
Id: {Id}
Make: {Make}
Model: {Model}
Created: {CreatedDate.ToShortDateString()}
";

}
