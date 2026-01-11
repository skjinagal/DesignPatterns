using Compound_Pattern.Interface;
namespace Compound_Pattern;
public class Flock : IQuackable
{
    private readonly List<IQuackable> quackers = new List<IQuackable>();

    public void Add(IQuackable quacker)
    {
        quackers.Add(quacker);
    }

    public void Quack()
    {
        foreach (var quacker in quackers)
        {
            quacker.Quack();
        }
    }
}