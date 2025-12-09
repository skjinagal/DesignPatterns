using Observer_Pattern.Interfaces;

namespace Observer_Pattern.Displays;
public class StatisticsDisplay : IDisplay
    {
        private double maxTemp = double.MinValue;
        private double minTemp = double.MaxValue;
        private double tempSum = 0.0;
        private int numReadings = 0;

        public void Udpate(double temperature, double humidity, double pressure) 
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
            Console.WriteLine("Displaying statistics...");
        }
    }