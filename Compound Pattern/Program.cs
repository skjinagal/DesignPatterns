// See https://aka.ms/new-console-template for more information
using Compound_Pattern.Ducks;
using Compound_Pattern.Interface;
Console.WriteLine("Hello, World!");

IQuackable mallardDuck = new MallardDuck();
IQuackable redHeadDuck = new RedHeadDuck();
IQuackable rubberDuck = new RubberDuck();
IQuackable duckCall = new DuckCall();
Simulate(mallardDuck);
Simulate(redHeadDuck);
Simulate(rubberDuck);
Simulate(duckCall);
void Simulate(IQuackable duck)
{
    duck.Quack();
}

