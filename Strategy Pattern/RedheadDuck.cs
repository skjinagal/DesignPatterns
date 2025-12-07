using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavior = new Squeak();
        swimBehavior = new Swimming();
    }
    public override void Display()
    {
        System.Console.WriteLine("I'm a Redhead Duck!");
    }
}