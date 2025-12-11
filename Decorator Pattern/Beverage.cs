namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        public string Description { get; protected set; }
        public virtual string GetDescription()
        {
            return Description;
        }
        public abstract double Cost();
    }
}