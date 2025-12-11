using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas;
public class ChicagoStyleCheesePizza : IPizza
{
    public string GetDescription()
    {
        return "Chicago Style Cheese Pizza";
    }

    public double GetCost()
    {
        return 15.00;
    }
}