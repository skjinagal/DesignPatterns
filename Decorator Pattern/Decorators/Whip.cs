namespace Decorator_Pattern.Decorators;
public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Whip";
    }

    public override double Cost()
    {
        return 0.10 + beverage.Cost();
    }
}