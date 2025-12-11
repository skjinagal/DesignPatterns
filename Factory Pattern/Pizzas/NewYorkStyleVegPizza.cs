using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas;

public class NewYorkStyleVegPizza : IPizza
{
    public string GetDescription()
    {
        return "New York Style Veg Pizza";
    }

    public double GetCost()
    {
        return 16.00;
    }
}