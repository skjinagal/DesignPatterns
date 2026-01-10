// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using Compound_Pattern.Ducks;
using Compound_Pattern.Interface;
using Compound_Pattern.Goose;
Console.WriteLine("Hello, World!");

IQuackable mallardDuck = new MallardDuck();
IQuackable redHeadDuck = new RedHeadDuck();
IQuackable rubberDuck = new RubberDuck();
IQuackable duckCall = new DuckCall();
IQuackable gooseDuck = new GooseAdaptor(new Goose());
Simulate(mallardDuck);
Simulate(redHeadDuck);
Simulate(rubberDuck);
Simulate(duckCall);
Simulate(gooseDuck);
void Simulate(IQuackable duck)
{
    duck.Quack();
}

