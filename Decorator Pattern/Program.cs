// See https://aka.ms/new-console-template for more information
using Decorator_Pattern.Decorators;
using Decorator_Pattern;
Console.WriteLine("Hello, World!");

Console.WriteLine("Star Buzz Coffee Shop");

while(true)
{
    Console.WriteLine("Select Beverage: 1. Expresso 2. DarkRoast 3. HouseBlend 4. Decaf 5. Exit");
    var choice = Console.ReadLine();
    if (choice == "5")
    return; // or break if inside a loop
    Beverage beverage = choice switch
    {
        "1" => new Expresso(),
        "2" => new DarkRoast(),
        "3" => new HouseBlend(),
        "4" => new Decaf(),
        _ => null
    };

    if (beverage == null)
    {
        Console.WriteLine("Invalid choice, try again.");
        continue;
    }

    Console.WriteLine("Add Condiments: 1. Mocha 2. Soy 3. Whip 4. No more condiments");
    while (true)
    {
        var condimentChoice = Console.ReadLine();
        if (condimentChoice == "4")
            break;

        beverage = condimentChoice switch
        {
            "1" => new Mocha(beverage),
            "2" => new Soy(beverage),
            "3" => new Whip(beverage),
            "4" => new Whip(beverage),
            _ => beverage
        };
    }

    Console.WriteLine($"{beverage.GetDescription()} $ {beverage.Cost()}");
}
