using Factory_Pattern.Interfaces;
using Factory_Pattern.Pizzas; 
namespace Factory_Pattern
{
    public class PizzaStore : IPizzaStore
    {
        private readonly IPizzaFactory _pizzaFactory;

        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(string type)
        {
            IPizza pizza = _pizzaFactory.CreatePizza(type);
            return pizza;
        }
    }
}