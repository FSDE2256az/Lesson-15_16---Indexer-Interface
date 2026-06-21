using MyInterface._1.InterfaceWithAbstract;
using MyInterface._2.InterfaceExtend;
using MyInterface._3.InterfaceWithProperty.ClassAndInterface;
using MyInterface._3.InterfaceWithProperty.Interfaces;
using MyInterface._4.SOLID_Interface_Segragation.BadExample;
using MyInterface._4.SOLID_Interface_Segragation.GoodExample;
using MyInterface._5.ImplicitAndExplicit;
using MyInterface._6.DefaultImplementation;

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

        // List<IClassic> cars = new List<IClassic>();
        // 
        // cars.Add(new Mercedes());
        // cars.Add(new UAZ());
        // 
        // foreach (var car in cars)
        // {
        //     car.Classic();
        // 
        //     if (car is ITurbo s)
        //         s.Turbo();
        // 
        // }

        #endregion

        #region InterfaceExtend

        // var some = new Some();
        // 
        // some.Boo();
        // some.Foo();

        #endregion

        #region InterfaceWithProperty

        // var workers = new List<IWorker>();
        //
        //
        // workers.Add(new Cashier());
        // workers.Add(new Cashier());
        // workers.Add(new Seller());
        // workers.Add(new Seller());
        // workers.Add(new Seller());
        // workers.Add(new Director());
        //
        // foreach (var worker in workers)
        // {
        //     worker.Work();
        // }

        #endregion

        #region InterfaceSegragation

        #region BadCase

        // var players = new List<IPlayer>();
        // 
        // players.Add(new DivMediaPlayer());
        // players.Add(new WinApp());
        // players.Add(new CavidPlayer());
        // 
        // foreach (var player in players)
        // {
        //     player.PlayAudio();
        //     player.PlayVideo();
        // }

        #endregion

        #region GoodCase

        // var audioPlayer = new List<IAudioPlayer>();
        // 
        // audioPlayer.Add(new MyInterface._4.SOLID_Interface_Segragation.GoodExample.DivMediaPlayer());
        // audioPlayer.Add(new MyInterface._4.SOLID_Interface_Segragation.GoodExample.WinApp());
        // //audioPlayer.Add(new MyInterface._4.SOLID_Interface_Segragation.GoodExample.CavidPlayer());
        // 
        // foreach (var item in audioPlayer)
        //     item.PlayAudio();
        // 
        // 
        // var videoPlayer = new List<IVideoPlayer>();
        // 
        // videoPlayer.Add(new MyInterface._4.SOLID_Interface_Segragation.GoodExample.DivMediaPlayer());
        // //videoPlayer.Add(new MyInterface._4.SOLID_Interface_Segragation.GoodExample.WinApp());
        // videoPlayer.Add(new MyInterface._4.SOLID_Interface_Segragation.GoodExample.CavidPlayer());
        // 
        // 
        // foreach (var item in videoPlayer)
        //     item.PlayVideo();

        #endregion

        #endregion

        #region ImplicitAndExplicit

        // var some = new Foo();
        // 
        // some.Get();
        // 
        // (some as IA).Get();
        // (some as IB).Get();

        #endregion

        #region DefaultImplementation

        // var rectangle = new Rectange();

        // rectangle.Draw();
        // // rectangle.Foo(); // adi vezyetde override etmemisikse gormuruk


        // var shapes = new List<IDraw>();
        // 
        // shapes.Add(new Rectange());
        // shapes.Add(new Circle());
        // 
        // 
        // foreach (var shape in shapes)
        // {
        //     shape.Draw();
        //     shape.Foo(); // override edilenin code-un verir, yoxdursa default implementation-u verir
        // }

        #endregion


        #region Information

        // Interface daxilinde neler yazmaq olar

        // 1. Property
        // 2. Methods
        // 3. Indexer ( IList, IDictionary )
        // 4. Event   ( NotifyPropertyChanged )

        // 5. Static field
        // 6. Constant
        // 7. Static contructor
        // 8. Operator


        // Interface daxilinde neler yazmaq olmaz!!!

        // 1. Field
        // 2. Constructor
        // 3. Destructor

        #endregion

    }
}
