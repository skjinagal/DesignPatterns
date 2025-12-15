// See https://aka.ms/new-console-template for more information
using Template_Method_Pattern;
Console.WriteLine("Hello, World!");

CaffeinBeverage tea = new Tea();
tea.PrepareRecipe();
Console.WriteLine();
CaffeinBeverage coffee = new Coffee();
coffee.PrepareRecipe();