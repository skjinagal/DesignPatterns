using Observer_Pattern.Interfaces;
namespace Observer_Pattern.Displays
{
    public class ForcastDisplay : IDisplay
    {
        public double Temperature { get; set; }

        public double Humidity { get; set; }

        public double Pressure { get; set; }

        public void Udpate(double temperature, double humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Displaying forecast conditions...");
        }
    }
}