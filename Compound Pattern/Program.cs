// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using Compound_Pattern.Ducks;
using Compound_Pattern.Interface;
using Compound_Pattern.Goose;
using Compound_Pattern;
Console.WriteLine("Hello, World!");

IQuackable mallardDuck = new QuackCounter( new MallardDuck() );
IQuackable redHeadDuck = new QuackCounter(  new RedHeadDuck() );
IQuackable rubberDuck = new QuackCounter( new RubberDuck() );
IQuackable duckCall = new QuackCounter( new DuckCall() );
IQuackable gooseDuck = new QuackCounter( new GooseAdaptor(new Goose()) );
Simulate(mallardDuck);
Simulate(redHeadDuck);
GetQuacks();
Simulate(rubberDuck);
Simulate(duckCall);
GetQuacks();
Simulate(gooseDuck);
GetQuacks();
void Simulate(IQuackable duck)
{
    duck.Quack();
}
void GetQuacks()
{
    Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks()} times");
}

