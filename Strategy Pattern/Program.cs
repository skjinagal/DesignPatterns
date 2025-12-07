namespace Strategy_Pattern;
public class Program
{
    static void Main(string[] args)
    {
        RedheadDuck redheadDuck = new RedheadDuck();
        redheadDuck.Display();
        redheadDuck.Quack();
        redheadDuck.Swim();
        redheadDuck.Fly();

        MallardDuck mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.Quack();
        mallardDuck.Swim();


        // whats happens    
    }
}