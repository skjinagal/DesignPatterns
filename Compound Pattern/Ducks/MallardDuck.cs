using Compound_Pattern.Interface;
namespace Compound_Pattern.Ducks
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack from Mallard Duck");
        }
    }
}