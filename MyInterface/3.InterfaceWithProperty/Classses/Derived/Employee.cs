using MyInterface._3.InterfaceWithProperty.Classses.Base;

namespace MyInterface._3.InterfaceWithProperty.Classses.Derived;

public abstract class Employee : Human
{
    public string Position { get; set; }
    public double Salary { get; set; }


    public override string ToString()
    => @$"{base.ToString()}
Position: {Position}
Salary: {Salary}";
}
