using Compound_Pattern.Interface;
namespace Compound_Pattern.Ducks
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}