 using Factory_Pattern.Interfaces;
 using Factory_Pattern.IngredientFactory;
 using Factory_Pattern.Ingredients;
namespace Factory_Pattern.Pizzas;
   
public class VeggiePizza : Pizza
{
    public Dough dough { get; set; }
    public Sauce sauce { get; set; }
    public Cheese cheese { get; set; }
    private IIngredientFactory ingredientFactory;
    public VeggiePizza(IIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }
    public override string GetDescription()
    {
        return " Veggie Pizza";
    }

    public override double GetCost()
    {
        return 18.00;
    }
    public override void prepair()
    {
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
    }
}  