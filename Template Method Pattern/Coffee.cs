namespace Template_Method_Pattern;
public class Coffee: CaffeinBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }
}