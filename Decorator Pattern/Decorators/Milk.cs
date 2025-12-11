namespace Decorator_Pattern.Decorators;
public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage)
    {
        this.beverage = beverage;
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