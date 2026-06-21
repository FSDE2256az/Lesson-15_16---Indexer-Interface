namespace Indexer_Record._1.Indexer;

public class CarGalary
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; } = new List<Car>();

    public CarGalary(string name)
    {
        Name = name;
    }

    public Car this[int index]
    {
        // get => Cars[index];

        get
        {
            if (index < 0 || index >= Cars.Count)
                throw new BusinessException("Index-den cixmisiniz");

            return Cars[index];
        }

        // set => Cars[index] = value;
        set
        {
            if (index < 0 || index >= Cars.Count)
                throw new BusinessException("Index-den cixmisiniz");
            Cars[index] = value;
        }
    }


    public override string ToString()
    => @$"
Name: {Name}

";

}
