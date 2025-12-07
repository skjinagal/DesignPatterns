using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class RedheadDuck : Duck, IFlyable, IQuackable
{
    public void Fly()
    {
        System.Console.WriteLine("Flying!");
    }
    public void Quack()
    {
        System.Console.WriteLine("Quack!");
    }
    public override void Display()
    {
        System.Console.WriteLine("I'm a Redhead Duck!");
    }
}