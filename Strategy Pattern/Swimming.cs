using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class Swimming : ISwimBehavior
{
    public void Swim()
    {
        System.Console.WriteLine("Swimming!");
    }
}