using Compound_Pattern.Interface;
namespace Compound_Pattern.Ducks
{
    public class RedHeadDuck : IQuackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack from RedHead Duck");
        }
    }
}