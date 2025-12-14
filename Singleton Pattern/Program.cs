// See https://aka.ms/new-console-template for more information
using Singleton_Pattern;

Console.WriteLine("Hello, World!");

var instance1 = ChoclateBoiler.GetInstance();
var instance2 = ChoclateBoiler.GetInstance();
if (instance1 == instance2)
{
    Console.WriteLine("Both instances are the same. Singleton works!");
}
else
{
    Console.WriteLine("Instances are different. Singleton failed.");
}