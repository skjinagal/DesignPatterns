namespace State_Pattern.States;
using State_Pattern.Interfaces;
public class HasQuarterState : IGumBallMachineState
{
    private readonly GumBallMachine gumBallMachine;

    public HasQuarterState(GumBallMachine gumBallMachine)
    {
        this.gumBallMachine = gumBallMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned.");
        gumBallMachine.SetState(gumBallMachine.NoQuarterState);
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        gumBallMachine.SetState(gumBallMachine.GumBallSoldState);
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed.");
    }
}