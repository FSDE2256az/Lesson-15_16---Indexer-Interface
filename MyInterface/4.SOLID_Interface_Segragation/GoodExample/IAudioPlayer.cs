namespace MyInterface._4.SOLID_Interface_Segragation.GoodExample;

interface IAudioPlayer { void PlayAudio(); }
interface IVideoPlayer { void PlayVideo(); }


public class DivMediaPlayer : IAudioPlayer, IVideoPlayer
{
    public void PlayAudio() => Console.WriteLine("DivMediaPlayer PlayAudio");

    public void PlayVideo() => Console.WriteLine("DivMediaPlayer PlayVideo");

}

public class WinApp : IAudioPlayer
{
    public void PlayAudio() => Console.WriteLine("WinApp PlayAudio");
}


public class CavidPlayer : IVideoPlayer
{
    public void PlayVideo() => Console.WriteLine("CavidPlayer PlayVideo");
}
