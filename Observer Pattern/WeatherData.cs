using Observer_Pattern.Displays;
using Observer_Pattern.Interfaces;
namespace Observer_Pattern;
public class WeatherData
{
    public float Temperature {get; set;}

    public float Humidity { get; set; }

    public float Pressure {get; set; }

    public IDisplay CurrentConditionsDisplay;

    public IDisplay StatisticsDisplay;

    public IDisplay ForcastDisplay;
    public WeatherData()
    {
        CurrentConditionsDisplay = new CurrentConditionsDisplay();
        StatisticsDisplay = new StatisticsDisplay();   
        ForcastDisplay = new ForcastDisplay();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        // Notify observers about the change (will implemented here)
        CurrentConditionsDisplay.Udpate(temperature, humidity, pressure);
        StatisticsDisplay.Udpate(temperature, humidity, pressure);  
        ForcastDisplay.Udpate(temperature, humidity, pressure);
    }
}