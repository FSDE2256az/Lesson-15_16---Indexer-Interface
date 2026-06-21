namespace Indexer_Record._2.Record;

public record Some
{
    public int Id { get; set; }
    public string? Name { get; set; }


    public Some(int id, string? name)
    {
        Id = id;
        Name = name;
    }

}


record Some2(int Id, string? Name);