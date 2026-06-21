namespace MyInterface._1.InterfaceWithAbstract;

public abstract class Car { } // Signature


// Interface

// 1. Interfaceler adlandirilma zamani 'I' herfi ile baslamalidir
// 2. Interface daxilinde yazilan methodlarin bedeni olmur ( Yeni versiyalarda mumkundur )
// 3. Methodlar default olaraq PUBLIC olur

interface ITurbo { void Turbo(); }
interface ISport { void Sport(); }
interface IClassic { void Classic(); }


// Implement etmeye mecburdu Derived class
class Mercedes : Car, ITurbo, ISport, IClassic
{
    public void Classic() => Console.WriteLine("Mercedes Classic");
    public void Sport() => Console.WriteLine("Mercedes Sport");
    public void Turbo() => Console.WriteLine("Mercedes Turbo");

}

class UAZ : Car, IClassic
{
    public void Classic() => Console.WriteLine("UAZ Classic");
}
