// See https://aka.ms/new-console-template for more information
using Adaptor_and_Facade;
using Adaptor_and_Facade.Interfaces;
Console.WriteLine("Hello, World!");
IDuck duck = new Duck();
ITurkey turkey = new Turkey();
IDuck turkeyAdaptor = new DuckAdaptor(turkey);
Console.WriteLine("The Turkey says...");
turkey.Gobble();    
turkey.Fly();
Console.WriteLine();
Console.WriteLine("The Duck says...");
duck.Quack();
duck.Fly();
Console.WriteLine();
Console.WriteLine("The TurkeyAdaptor says...");
turkeyAdaptor.Quack();
turkeyAdaptor.Fly();

