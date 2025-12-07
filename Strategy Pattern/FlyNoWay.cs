using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        System.Console.WriteLine("I can't fly!");
    }
}