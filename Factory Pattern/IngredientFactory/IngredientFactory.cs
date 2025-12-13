using Factory_Pattern.Ingredients;
namespace Factory_Pattern.IngredientFactory
{
    public interface IIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
    }
}