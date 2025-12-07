using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class NoSwim : ISwimBehavior
{
    public void Swim()
    {
        System.Console.WriteLine("I can't swim!");
    }
}