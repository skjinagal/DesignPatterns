using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        System.Console.WriteLine("<< Silence >>");
    }
}