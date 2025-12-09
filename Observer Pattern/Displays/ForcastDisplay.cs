using Observer_Pattern.Interfaces;
namespace Observer_Pattern.Displays
{
    public class ForcastDisplay : IObserver, IDisplay
    {
        private float Temperature;

        public float Humidity;

        public float Pressure;

        public ForcastDisplay(ISubject weatherData)
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
            Console.WriteLine("Forcast conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
        }
    }
}