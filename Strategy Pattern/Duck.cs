namespace Strategy_Pattern;
public abstract class Duck 
{
    public void Swim()
    {
        System.Console.WriteLine("Swimming!");
    }

    public abstract void Display();
}