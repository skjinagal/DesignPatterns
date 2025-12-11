 using Factory_Pattern.Interfaces;
namespace Factory_Pattern.Pizzas;
   
public class ChicagoStyleVeggiePizza : IPizza
{
    public string GetDescription()
    {
        return "Chicago Style Veggie Pizza with thick crust, tomato sauce, mozzarella cheese, bell peppers, onions, mushrooms, and olives.";
    }

    public double GetCost()
    {
        return 18.00;
    }
}  