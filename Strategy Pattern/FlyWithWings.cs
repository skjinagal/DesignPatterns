using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        System.Console.WriteLine("Flying with wings!");
    }
}
