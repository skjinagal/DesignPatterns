using Compound_Pattern.Interface;
namespace Compound_Pattern.Factory
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedheadDuck(); 
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
        public abstract IQuackable CreateGooseDuck();
    }
}