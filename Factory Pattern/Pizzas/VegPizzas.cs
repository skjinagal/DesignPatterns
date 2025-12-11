using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas
{
    public class VegPizza: IPizza
    {
        public string GetDescription()
        {
            return "Veg Pizza with tomato sauce, mozzarella cheese, and assorted vegetables.";
        }

        public double GetCost()
        {
            return 9.99;
        }
    }
}