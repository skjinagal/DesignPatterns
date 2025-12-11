namespace Decorator_Pattern.Docorators;
public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Milk";
    }

    public override double Cost()
    {
        return 0.10 + beverage.Cost();
    }
}