namespace Decorator_Pattern
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso Coffee";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}