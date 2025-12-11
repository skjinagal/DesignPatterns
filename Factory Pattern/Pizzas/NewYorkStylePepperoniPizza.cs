 using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas;
   
public class NewYorkStylePepperoniPizza : IPizza
{
    public string GetDescription()
    {
        return "New York Style Pepperoni Pizza";
    }

    public double GetCost()
    {
        return 15.00;
    }
}