using Factory_Pattern.Pizzas;
using Factory_Pattern.Interfaces;
using Factory_Pattern.IngredientFactory;
namespace Factory_Pattern.PizzaStores;
public class  ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {   
        var ingredientFactory = new ChicagoIngredientFactory();

        Pizza pizza = null;
        if (type.Equals("cheese"))
        {
            pizza = new CheesePizza(ingredientFactory);
        }
        else if (type.Equals("veggie"))
        {
            pizza = new VeggiePizza(ingredientFactory);
        }
        else if( type.Equals("pepperoni"))
        {
            pizza = new PepperoniPizza(ingredientFactory);
        }
        return pizza;
    }
} 