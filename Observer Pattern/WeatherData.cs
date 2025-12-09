using Observer_Pattern.Displays;
using Observer_Pattern.Interfaces;
namespace Observer_Pattern;
public class WeatherData : ISubject
{
    public float Temperature {get; set;}

    public float Humidity { get; set; }

    public float Pressure {get; set; }

    public List<IObserver> Observers = new List<IObserver>();
    public WeatherData()
    {
       Observers = new List<IObserver>();
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
        Observers.ForEach(o => o.Udpate(Temperature, Humidity, Pressure));
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