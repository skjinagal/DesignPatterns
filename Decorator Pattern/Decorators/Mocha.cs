namespace Decoraotor_Pattern.Decorators;
public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return 0.20 + beverage.Cost();
    }
}