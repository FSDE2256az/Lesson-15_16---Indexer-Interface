using MyInterface._1.InterfaceWithAbstract;

namespace MyInterface;

public class Program
{
    static void Main(string[] args)
    {
        #region Xulase

        // Interface

        // 1. Standart interface    => Dilin oz uzerinde gelenler  ( IDisposible, ICloneable )
        // 2. Custom interface      => Bizim yaratdiqlarimiz

        // /////////////////////////////// 

        // Inheritance ( is a ) Pisik bir heyvar
        // Association ( has a, part of )

        // Interface ( can do ) => Multiple base 

        // /////////////////////////////// 

        // Interface 
        // 1. Referance type
        // 2. Objecti yaranmir
        // 3. Multiple base etmek olur, yeni 1 class 1+ interface-den torene bilir

        #endregion

        #region InterfaceWithAbstractClass

        // var mercedes = new Mercedes();

        // mercedes.Turbo();
        // mercedes.Sport();
        // mercedes.Classic();


        //  IClassic mercedes2 = new Mercedes();
        //  mercedes2.Classic();
        // 
        //  (mercedes2 as ITurbo)!.Turbo();
        //  (mercedes2 as ISport)!.Sport();

        List<IClassic> cars = new List<IClassic>();

        cars.Add(new Mercedes());
        cars.Add(new UAZ());

        foreach (var car in cars)
        {
            car.Classic();

            if (car is ITurbo s)
                s.Turbo();
        
        }



        #endregion





    }
}
