using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas
{
    public class CheesePizza : IPizza
    {
        public string GetDescription()
        {
            return "Cheese Pizza with tomato sauce and mozzarella cheese.";
        }

        public double GetCost()
        {
            return 8.99;
        }
    }
}