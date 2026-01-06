namespace Proxy_Pattern
{
    public class ProxySubject : ISubject
    {
        private RealSubject _realSubject;
        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            Console.WriteLine("Proxy Subject Delegating Request to Real Subject");
            _realSubject.Request();
        }
    }
}