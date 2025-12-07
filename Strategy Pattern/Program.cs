namespace Strategy_Pattern;
public class Program
{
    static void Main(string[] args)
    {
        Duck redheadDuck = new RedheadDuck();
        redheadDuck.Display();
        redheadDuck.PerformQuack();
        redheadDuck.PerformSwim();
        redheadDuck.PerformFly();

        Duck mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.PerformQuack();
        mallardDuck.PerformSwim();
        mallardDuck.PerformFly();

        Duck rubberDuck = new RubberDuck();
        rubberDuck.Display();
        rubberDuck.PerformQuack();
        rubberDuck.PerformSwim();  
        rubberDuck.PerformFly();


        // whats happens    
    }
}