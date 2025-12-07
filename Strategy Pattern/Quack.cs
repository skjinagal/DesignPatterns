using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class Quack : IQuackBehavior
{
    public void Quack()
    {
        System.Console.WriteLine("Quacking!");
    }
}