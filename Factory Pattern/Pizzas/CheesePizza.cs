using Factory_Pattern.Interfaces;
using Factory_Pattern.IngredientFactory;
using Factory_Pattern.Ingredients;
namespace Factory_Pattern.Pizzas;
public class CheesePizza : Pizza
{
    private IIngredientFactory ingredientFactory;
    public Dough dough;
    public Sauce sauce;
    public Cheese cheese;

    public CheesePizza(IIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }
    public override string GetDescription()
    {
        return " Cheese Pizza";
    }

    public override double GetCost()
    {
        return 15.00;
    }

    public override void prepair()
    {
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
    }
}