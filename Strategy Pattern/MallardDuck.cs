using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class MallardDuck : Duck, IQuackable
{
    public void Quack()
    {
        System.Console.WriteLine("Quack!");
    }

    public override void Display()
    {
        System.Console.WriteLine("I'm a Mallard Duck!");
    }
}