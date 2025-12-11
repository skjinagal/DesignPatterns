using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas;
public class ChicagoStylePepperoniPizza : IPizza
{
    public string GetDescription()
    {
        return "Chicago Style Pepperoni Pizza";
    }

    public double GetCost()
    {
        return 18.00;
    }
}