using MyInterface._3.InterfaceWithProperty.Interfaces;
using MyInterface._3.InterfaceWithProperty.Classses.Derived;

namespace MyInterface._3.InterfaceWithProperty.ClassAndInterface;

public class Director : Employee, IManager, IWorker
{
    public bool IsWorking { get; set; }

    public void Control() => Console.WriteLine("Director Control");

    public void Organize() => Console.WriteLine("Director Organize");

    public void Work() => Console.WriteLine("Director Work");
}
