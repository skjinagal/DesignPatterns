using Observer_Pattern.Interfaces;
namespace Observer_Pattern.Displays
{
    public class ForcastDisplay : IObserver, IDisplay
    {
        private float Temperature;

        public float Humidity;

        public float Pressure;
        private ISubject weatherData;

        public ForcastDisplay(ISubject weatherData)
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
            Console.WriteLine("Forcast conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
        }
    }
}