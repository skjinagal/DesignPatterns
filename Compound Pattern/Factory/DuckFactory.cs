using Compound_Pattern.Interface;
using Compound_Pattern.Gooses;
using Compound_Pattern.Ducks;
namespace Compound_Pattern.Factory;
public class DuckFactory : AbstractDuckFactory
{
    public override IQuackable CreateMallardDuck()
    {
        return new MallardDuck();
    }

    public override IQuackable CreateRedheadDuck()
    {
        return new RedHeadDuck();
    }

    public override IQuackable CreateDuckCall()
    {
        return new DuckCall();
    }

    public override IQuackable CreateRubberDuck()
    {
        return new RubberDuck();
    }

    public override IQuackable CreateGooseDuck()
    {
        return new GooseAdaptor(new Goose());
    }
}