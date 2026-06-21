using Indexer_Record._1.Indexer;
using Indexer_Record._2.Record;

namespace Indexer_Record;

internal class Program
{
    static void Main(string[] args)
    {
        #region Indexer

        // CarGalary carGalary = new("Kia Service");
        // 
        // 
        // carGalary.Cars.Add(new Car()
        // {
        //     Id = Guid.NewGuid(),
        //     Make = "Kia",
        //     Model = "Sorento",
        //     CreatedDate = new DateTime(2025, 1, 1)
        // });
        // 
        // carGalary.Cars.Add(new Car()
        // {
        //     Id = Guid.NewGuid(),
        //     Make = "Kia",
        //     Model = "K5",
        //     CreatedDate = new DateTime(2016, 12, 1)
        // });
        // 
        // 
        // carGalary.Cars.Add(new Car()
        // {
        //     Id = Guid.NewGuid(),
        //     Make = "Kia",
        //     Model = "Ceed",
        //     CreatedDate = new DateTime(2008, 12, 1)
        // });
        // 
        // 
        // // Console.WriteLine(carGalary.Cars[0]);
        // // 
        // // foreach (var item in carGalary.Cars)
        // // {
        // //     Console.WriteLine(item);
        // // }
        // 
        // Console.WriteLine(carGalary[0]);
        // 
        // carGalary.Cars.Add(new Car()
        // {
        //     Id = Guid.NewGuid(),
        //     Make = "Kia",
        //     Model = "Forte",
        //     CreatedDate = new DateTime(2018, 9, 1)
        // });
        // 
        // //Console.WriteLine(carGalary[carGalary.Cars.Count - 1]);
        // 
        // Console.WriteLine(carGalary[-1]);

        #endregion

        #region Record

        // var some = new Some(1, "Yusuf");
        // var some2 = new Some2(2, "Xayyam");
        // 
        // Console.WriteLine(some);
        // Console.WriteLine(some2);

        #endregion

        #region Enviroment

        // System haqqinda melumatlari almaq ucundur

        // Console.WriteLine(Environment.CommandLine);
        // Console.WriteLine(Environment.MachineName);
        // Console.WriteLine(Environment.OSVersion);
        // Console.WriteLine(Environment.CurrentManagedThreadId);

        // Console.WriteLine(Environment.GetEnvironmentVariable("development"));
        // Console.WriteLine(Environment.CurrentDirectory);

        // Console.WriteLine(Environment.ExitCode);

        // Environment.Exit(0);
        // Console.WriteLine("Hello world! ");

        #endregion

        #region TupleReturnDataInMethod

        (int, string) col = Foo();

        Console.WriteLine(col.Item1);
        Console.WriteLine(col.Item2);

        #endregion

    }

    private static (int, string) Foo()
    {
        int number = 5;
        string name = "Kamran";

        return (number, name);
    }
}
