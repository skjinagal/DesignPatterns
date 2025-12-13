using Factory_Pattern.Ingredients;
namespace Factory_Pattern.IngredientFactory;

public class NYIngredientFactory: IIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Cheese CreateCheese()
    {
        return new MozirellaCheese();
    }
}