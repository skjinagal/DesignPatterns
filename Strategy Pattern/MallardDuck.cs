using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class MallardDuck : Duck
{
    public MallardDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavior = new Quacking();
        swimBehavior = new Swimming();
    }

    public override void Display()
    {
        System.Console.WriteLine("I'm a Mallard Duck!");
    }
}