using Compound_Pattern.Interface;
namespace Compound_Pattern.Gooses;
public class GooseAdaptor : IQuackable
{
    private readonly Goose _goose;

    public GooseAdaptor(Goose goose)
    {
        _goose = goose;
    }

    public void Quack()
    {
        _goose.Honk();
    }
}