using Adaptor_and_Facade.Interfaces;
namespace Adaptor_and_Facade;
public class Duck: IDuck
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }
}