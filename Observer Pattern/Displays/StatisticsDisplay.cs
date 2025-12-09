using Observer_Pattern.Interfaces;

namespace Observer_Pattern.Displays;
public class StatisticsDisplay : IObserver, IDisplay
    {
        private float maxTemp = float.MinValue;
        private float minTemp = float.MaxValue;
        private float tempSum = 0.0F;
        private int numReadings = 0;

        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public void Udpate(float temperature, float humidity, float pressure) 
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp) 
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp) 
            {
                minTemp = temperature;
            }

            Display();
        }

        public void Display() 
        {
            Console.WriteLine("Displaying Statistics: Max/Min/Avg temperature = " + maxTemp + "/" + minTemp + "/" + (tempSum / numReadings) );
        }
    }