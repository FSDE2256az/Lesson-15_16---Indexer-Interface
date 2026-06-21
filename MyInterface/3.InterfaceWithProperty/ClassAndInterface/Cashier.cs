using MyInterface._3.InterfaceWithProperty.Classses.Derived;
using MyInterface._3.InterfaceWithProperty.Interfaces;

namespace MyInterface._3.InterfaceWithProperty.ClassAndInterface;

public class Cashier : Employee, IWorker
{
    public bool IsWorking { get; set; }

    public void Work() => Console.WriteLine("Cashier work");
}
