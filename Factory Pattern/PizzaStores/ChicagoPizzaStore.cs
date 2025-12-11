using Factory_Pattern.Pizzas;
using Factory_Pattern.Interfaces;
namespace Factory_Pattern.PizzaStores;
public class  ChicagoPizzaStore : PizzaStore
{
    public override IPizza CreatePizza(string type)
    {
        IPizza pizza = null;
        if (type.Equals("cheese"))
        {
            pizza = new ChicagoStyleCheesePizza();
        }
        else if (type.Equals("veggie"))
        {
            pizza = new NewYorkStyleVegPizza();
        }
        else if( type.Equals("pepperoni"))
        {
            pizza = new ChicagoStylePepperoniPizza();
        }
        return pizza;
    }
} 