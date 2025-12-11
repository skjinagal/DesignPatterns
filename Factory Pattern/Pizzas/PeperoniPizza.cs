using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas
{
    public class PepperoniPizza : IPizza
    {
        public string GetDescription()
        {
            return "Pepperoni Pizza with tomato sauce, mozzarella cheese, and pepperoni slices.";
        }

        public double GetCost()
        {
            return 10.99;
        }
    }
}