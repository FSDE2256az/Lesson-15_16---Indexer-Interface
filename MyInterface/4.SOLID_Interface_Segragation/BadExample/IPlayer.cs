namespace MyInterface._4.SOLID_Interface_Segragation.BadExample;

interface IPlayer
{
    void PlayAudio();
    void PlayVideo();
}


public class DivMediaPlayer : IPlayer
{
    public void PlayAudio() => Console.WriteLine("DivMediaPlayer PlayAudio");

    public void PlayVideo() => Console.WriteLine("DivMediaPlayer PlayVideo");
}

public class WinApp : IPlayer
{
    public void PlayAudio() => Console.WriteLine("WinApp PlayAudio");

    public void PlayVideo() { Console.WriteLine("WinApp PlayVideo Islemir"); }
}


public class CavidPlayer : IPlayer
{
    public void PlayAudio() { Console.WriteLine("CavidPlayer PlayAudio Islemir"); }

    public void PlayVideo() => Console.WriteLine("CavidPlayer PlayVideo");
}
