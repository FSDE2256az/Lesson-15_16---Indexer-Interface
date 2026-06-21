namespace MyInterface._2.InterfaceExtend;

interface IFoo
{
    void Foo();
}

interface IBoo : IFoo
{
    void Boo();
}


public class Some : IBoo
{
    public void Boo()
    {
        Console.WriteLine("Some Boo");
    }

    public void Foo()
    {
        Console.WriteLine("Some Foo");
    }
}

