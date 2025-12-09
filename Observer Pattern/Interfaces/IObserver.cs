namespace Observer_Pattern.Interfaces;

    public interface IObserver
    {
        void Udpate(float temperature, float humidity, float pressure);
    }
