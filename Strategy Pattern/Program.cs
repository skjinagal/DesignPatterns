namespace Strategy_Pattern;
public class Program
{
    static void Main(string[] args)
    {
        Duck redheadDuck = new RedheadDuck();
        redheadDuck.Display();
        redheadDuck.Quack();
        redheadDuck.Swim();

        Duck mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.Quack();
        mallardDuck.Swim();

        // whats happens    
    }
}