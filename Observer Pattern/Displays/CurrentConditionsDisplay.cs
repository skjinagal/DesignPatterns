using Observer_Pattern.Interfaces;
namespace Observer_Pattern.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float Temperature;
        private float Humidity;
        private float Pressure;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Udpate() 
        {
            Temperature = this.weatherData.GetTemperature();
            Humidity = this.weatherData.GetHumidity();
            Pressure = this.weatherData.GetPressure();
            Display();
        }
        public void Display() 
        {
            Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");

        }
    }
}