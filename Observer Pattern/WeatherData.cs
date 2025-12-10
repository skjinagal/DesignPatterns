using Observer_Pattern.Displays;
using Observer_Pattern.Interfaces;
namespace Observer_Pattern;
public class WeatherData : ISubject
{
    private float Temperature {get; set;}

    private float Humidity { get; set; }

    private float Pressure {get; set; }

    private List<IObserver> Observers = new List<IObserver>();
    public WeatherData()
    {
       Observers = new List<IObserver>();
    }

    public float GetTemperature()
    {
        return Temperature;
    }

    public float GetHumidity()
    {
        return Humidity;
    }

    public float GetPressure()
    {
        return Pressure;
    }  
    public void RegisterObserver(IObserver o)
    {
        Observers.Add(o);
    }
    public void RemoveObserver(IObserver o)
    {
        Observers.Remove(o);
    }
    public void NotifyObservers()
    {
        Observers.ForEach(o => o.Udpate());
    }
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        // Notify observers about the change (will implemented here)
        NotifyObservers();
    }
}