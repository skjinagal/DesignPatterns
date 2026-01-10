// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using Compound_Pattern.Ducks;
using Compound_Pattern.Interface;
using Compound_Pattern.Gooses;
using Compound_Pattern;
using Compound_Pattern.Factory;
Console.WriteLine("Hello, World!");

AbstractDuckFactory duckFactory = new CountingDuckFactory();
IQuackable mallardDuck = duckFactory.CreateMallardDuck();
IQuackable redHeadDuck = duckFactory.CreateRedheadDuck();
IQuackable rubberDuck = duckFactory.CreateRubberDuck();
IQuackable duckCall = duckFactory.CreateDuckCall();
IQuackable gooseDuck = duckFactory.CreateGooseDuck();
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

