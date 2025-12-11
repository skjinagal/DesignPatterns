namespace Decorator_Pattern.Decorators;
public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Soy";
    }

    public override double Cost()
    {
        return 0.15 + beverage.Cost();
    }
}