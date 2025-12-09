// See https://aka.ms/new-console-template for more information
using Observer_Pattern;
using Observer_Pattern.Displays;
Console.WriteLine("Hello, Sun Shine!");
WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForcastDisplay forcastDisplay = new ForcastDisplay(weatherData);
while(true)
{
    Console.WriteLine("Weather Station");
    Console.WriteLine("1.Press Enter to input new weather data.\n 2. Press 'q' to quit.");
    var entry = Console.ReadLine();
    if(entry == "q")
    {
        break;
    }
    else
    {
        Console.WriteLine("Input new weather data:");
        Console.WriteLine("Enter temperature: ");
        var tempInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter humidity: ");
        var humidityInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter pressure: ");
        var pressureInput = Convert.ToDouble(Console.ReadLine());
        // Here we can create WeatherData object and set the measurements
        
        weatherData.SetMeasurements((float)tempInput, (float)humidityInput, (float)pressureInput);
    }    
}
