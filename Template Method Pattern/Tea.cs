namespace Template_Method_Pattern;
public class Tea: CaffeinBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }
}