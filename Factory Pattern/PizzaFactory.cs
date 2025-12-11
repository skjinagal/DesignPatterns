using Factory_Pattern.Interfaces;
using Factory_Pattern.Pizzas;
namespace Factory_Pattern
{
    public class PizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "cheese":
                    return new CheesePizza();
                case "peperoni":
                    return new PepperoniPizza();
                case "veggie":
                    return new VegPizza();
                default:
                    throw new ArgumentException("Invalid pizza type");
            }
        }
    }
}