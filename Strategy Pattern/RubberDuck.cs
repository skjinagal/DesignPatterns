using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class RubberDuck : Duck
{
    public RubberDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new MuteQuack();
        swimBehavior = new NoSwim();
    }

    public override void Display()
    {
        System.Console.WriteLine("I'm a Rubber Duck!");
    }
}