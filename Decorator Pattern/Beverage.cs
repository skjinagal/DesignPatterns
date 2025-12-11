namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        public string Description { get; protected set; } = "Unknown Beverage";
        public string GetDescription()
        {
            return Description;
        }
        public abstract double Cost();
    }
}