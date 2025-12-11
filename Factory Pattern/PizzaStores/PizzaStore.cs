using Factory_Pattern.Interfaces;
namespace Factory_Pattern.PizzaStores;
public abstract class PizzaStore
{
    public IPizza OrderPizza(string type)
    {
        IPizza pizza = CreatePizza(type);
        pizza.GetDescription();
        pizza.GetCost();
        return pizza;
    }
    public abstract IPizza CreatePizza(string type);
}