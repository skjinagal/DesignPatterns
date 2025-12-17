// See https://aka.ms/new-console-template for more information
using State_Pattern;
using State_Pattern.States;
using State_Pattern.Interfaces;
Console.WriteLine("Hello, World!");
GumBallMachine gumBallMachine = new GumBallMachine(2);
gumBallMachine.InsertQuarter();
gumBallMachine.TurnCrank();
gumBallMachine.InsertQuarter();
gumBallMachine.TurnCrank();

gumBallMachine.InsertQuarter();
gumBallMachine.TurnCrank();
gumBallMachine.EjectQuarter();
gumBallMachine.InsertQuarter();
gumBallMachine.TurnCrank();
gumBallMachine.InsertQuarter();
gumBallMachine.TurnCrank();
