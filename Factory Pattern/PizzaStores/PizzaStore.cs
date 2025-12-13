using Factory_Pattern.Interfaces;
namespace Factory_Pattern.PizzaStores;
public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);
        pizza.GetDescription();
        pizza.GetCost();
        pizza.prepair();
        return pizza;
    }
    public abstract Pizza CreatePizza(string type);
}