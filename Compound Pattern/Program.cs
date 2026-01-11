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

Flock flockOfDucks = new Flock();
flockOfDucks.Add(mallardDuck);
flockOfDucks.Add(redHeadDuck);
flockOfDucks.Add(rubberDuck);
flockOfDucks.Add(duckCall);
flockOfDucks.Add(gooseDuck);
flockOfDucks.Quack();
GetQuacks();
void GetQuacks()
{
    Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks()} times");
}

