using Factory_Pattern.Ingredients;
namespace Factory_Pattern.IngredientFactory;
public class ChicagoIngredientFactory : IIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
        return new RegiannaCheese();
    }
}