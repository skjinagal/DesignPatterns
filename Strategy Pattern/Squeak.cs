using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        System.Console.WriteLine("Squeaking!");
    }
}