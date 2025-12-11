// See https://aka.ms/new-console-template for more information
using Factory_Pattern;
using Factory_Pattern.Interfaces;
using Factory_Pattern.Pizzas;
using Factory_Pattern.PizzaStores;

Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Pizza Store!");

PizzaStore nyStore = new NewYorkPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();
IPizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.GetDescription()} costing ${pizza.GetCost()}");
pizza = chicagoStore.OrderPizza("pepperoni");
Console.WriteLine($"Joel ordered a {pizza.GetDescription()} costing ${pizza.GetCost()}");

