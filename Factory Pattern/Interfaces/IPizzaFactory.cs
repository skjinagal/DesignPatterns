namespace Factory_Pattern.Interfaces
{
    public interface IPizzaFactory
    {
        
        IPizza CreatePizza(string type);
    }
}