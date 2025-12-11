using Factory_Pattern.Pizzas;
using Factory_Pattern.Interfaces;
namespace Factory_Pattern.PizzaStores;
public class NewYorkPizzaStore : PizzaStore
{
    public override IPizza CreatePizza(string type)
    {
        if (type == "cheese")
        {
            return new NewYorkStyleCheesePizza();
        }
        else if (type == "veggie")
        {
            return new NewYorkStyleVegPizza();
        }
        else if( type == "peperoni")
        {
            return new NewYorkStylePepperoniPizza();
        }
        else
        {
            return null;
        }
    }
}