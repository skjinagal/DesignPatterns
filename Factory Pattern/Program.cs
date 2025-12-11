// See https://aka.ms/new-console-template for more information
using Factory_Pattern;
using Factory_Pattern.Interfaces;
using Factory_Pattern.Pizzas;

Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Pizza Store!");
IPizzaFactory pizzaFactory = new PizzaFactory();
PizzaStore pizzaStore = new PizzaStore(pizzaFactory);   
IPizza pizza1 = pizzaStore.OrderPizza("Cheese");
Console.WriteLine($"You ordered a {pizza1.GetDescription()} costing ${pizza1.GetCost()}");
