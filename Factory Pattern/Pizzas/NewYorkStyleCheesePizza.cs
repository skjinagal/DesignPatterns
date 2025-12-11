 using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas;
public class NewYorkStyleCheesePizza : IPizza
{
    public string GetDescription()
    {
        return "New York Style Cheese Pizza";
    }

    public double GetCost()
    {
        return 18.00;
    }
}