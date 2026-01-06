// See https://aka.ms/new-console-template for more information
using Proxy_Pattern;
Console.WriteLine("Hello, World!");
ISubject proxy = new ProxySubject();
proxy.Request();
