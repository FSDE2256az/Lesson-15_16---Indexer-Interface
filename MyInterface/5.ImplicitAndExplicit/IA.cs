namespace MyInterface._5.ImplicitAndExplicit;

interface IA
{
    void Get();
}

interface IB
{
    void Get();
}


class Foo : IA, IB
{
    public void Get() => Console.WriteLine("Implicit imple");

    void IA.Get() => Console.WriteLine("IA imple");
    void IB.Get() => Console.WriteLine("IB imple");
}
