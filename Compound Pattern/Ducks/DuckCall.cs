using Compound_Pattern.Interface;
namespace Compound_Pattern.Ducks
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Kwak");
        }
    }
}