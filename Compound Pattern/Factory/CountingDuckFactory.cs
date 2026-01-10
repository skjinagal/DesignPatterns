using Compound_Pattern.Interface;
using Compound_Pattern.Ducks;
using Compound_Pattern.Gooses;
using Compound_Pattern;
namespace Compound_Pattern.Factory;
public class CountingDuckFactory : AbstractDuckFactory
{
    public override IQuackable CreateMallardDuck()
    {
        return new QuackCounter(new MallardDuck());
    }

    public override IQuackable CreateRedheadDuck()
    {
        return new QuackCounter(new RedHeadDuck());
    }

    public override IQuackable CreateDuckCall()
    {
        return new QuackCounter(new DuckCall());
    }

    public override IQuackable CreateRubberDuck()
    {
        return new QuackCounter(new RubberDuck());  
    }

    public override IQuackable CreateGooseDuck()
    {
        return new QuackCounter(new GooseAdaptor(new Goose()));
    }
}