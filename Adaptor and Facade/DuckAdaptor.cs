using Adaptor_and_Facade.Interfaces;
namespace Adaptor_and_Facade;
public class DuckAdaptor : IDuck
{
    private readonly ITurkey turkey;

    public DuckAdaptor(ITurkey turkey)
    {
        this.turkey = turkey;
    }

    public void Quack()
    {
        turkey.Gobble();
    }

    public void Fly()
    {
        for(int i =0; i<5; i++)
        {
            turkey.Fly();
        }
    }
}