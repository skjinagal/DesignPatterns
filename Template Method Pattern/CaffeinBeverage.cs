namespace Template_Method_Pattern;
public abstract class CaffeinBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }
    protected abstract void Brew();
    protected abstract void AddCondiments();
    void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }
    void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
}