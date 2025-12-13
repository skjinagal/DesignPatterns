using Factory_Pattern.Pizzas;
using Factory_Pattern.Interfaces;
using Factory_Pattern.IngredientFactory;
namespace Factory_Pattern.PizzaStores;
public class NewYorkPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        var ingredientFactory = new NYIngredientFactory();
        if (type == "cheese")
        {
            return new CheesePizza(ingredientFactory);
        }
        else if (type == "veggie")
        {
            return new VeggiePizza(ingredientFactory);
        }
        else if( type == "peperoni")
        {
            return new PepperoniPizza(ingredientFactory);
        }
        else
        {
            return null;
        }
    }
}