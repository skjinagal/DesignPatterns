namespace Decorator_Pattern.Decorators;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;

    public override abstract string GetDescription();
}