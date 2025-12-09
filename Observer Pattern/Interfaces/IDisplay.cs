namespace Observer_Pattern.Interfaces;

    public interface IDisplay
    {
        void Udpate(double temperature, double humidity, double pressure);
        void Display();
    }
