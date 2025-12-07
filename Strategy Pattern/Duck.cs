using Strategy_Pattern.Interfaces;
namespace Strategy_Pattern;
public abstract class Duck 
{
    public IQuackBehavior quackBehavior { get; set; }
    public IFlyBehavior flyBehavior { get; set; }
    public ISwimBehavior swimBehavior { get; set; }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }
    public void PerformQuack()
    {
        quackBehavior.Quack();
    }
    public void PerformSwim()
    {
        swimBehavior.Swim();
    }

    public abstract void Display();
}