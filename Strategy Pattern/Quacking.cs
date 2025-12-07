using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class Quacking : IQuackBehavior
{
    public void Quack()
    {
        System.Console.WriteLine("Quacking!");
    }
}