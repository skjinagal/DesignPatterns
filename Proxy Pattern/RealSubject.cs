namespace Proxy_Pattern
{
    public class RealSubject: ISubject
    {
        public void Request()
        {
            Console.WriteLine("Called Real Subject Request Method");
        }
    }
}