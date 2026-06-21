namespace MyInterface._6.DefaultImplementation;

public interface IDraw
{
    public void Foo() { Console.WriteLine("Default implementation"); }

    void Draw();

}


class Rectange : IDraw
{
    public void Draw() => Console.WriteLine("Rectange draw");
    public void Foo() => Console.WriteLine("Rectange Foo");

}

