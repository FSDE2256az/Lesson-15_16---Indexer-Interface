using MyInterface._3.InterfaceWithProperty.Interfaces;
using MyInterface._3.InterfaceWithProperty.Classses.Derived;

namespace MyInterface._3.InterfaceWithProperty.ClassAndInterface;

class Seller : Employee, IWorker
{
    public bool IsWorking { get; set; }

    public void Work() => Console.WriteLine("Seller work");

}
