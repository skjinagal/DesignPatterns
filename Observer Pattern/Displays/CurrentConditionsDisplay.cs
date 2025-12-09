using Observer_Pattern.Interfaces;
namespace Observer_Pattern.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float Temperature;
        private float Humidity;
        private float Pressure;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public void Udpate(float temperature, float humidity, float pressure) 
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            Display();
        }
        public void Display() 
        {
            Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");

        }
    }
}