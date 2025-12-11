namespace Factory_Pattern.Interfaces;
public interface IPizzaStore
{
    IPizza OrderPizza(string type);
}