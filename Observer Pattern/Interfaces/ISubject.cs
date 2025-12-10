namespace Observer_Pattern.Interfaces;
public interface ISubject
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();

    float GetTemperature();
    float GetHumidity();
    float GetPressure();
}