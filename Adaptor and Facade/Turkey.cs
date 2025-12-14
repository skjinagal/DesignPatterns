using Adaptor_and_Facade.Interfaces;
namespace Adaptor_and_Facade;
public class Turkey: ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying a short distance");
    }
}   