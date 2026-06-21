namespace MyInterface._7.Task;

interface IKiller
{
    void CanKill();
}

interface IFighter
{
    void CanAttack();
    void CanFire();
    void CanShot();
}

interface IManager
{
    void Control();
    void CompleteMission();
    void GatherPeople();
}


class Fighter : IFighter, IKiller
{
    public void CanAttack() => Console.WriteLine("Attack");
    public void CanFire() => Console.WriteLine("Fire");
    public void CanShot() => Console.WriteLine("Shot");

    public void CanKill() => Console.WriteLine("Killer");
}


class Commander : Fighter, IManager
{
    public void CompleteMission() => Console.WriteLine("Complete Mission");
    public void Control() => Console.WriteLine("Control");
    public void GatherPeople() => Console.WriteLine("Gather People");
}






