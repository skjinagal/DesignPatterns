namespace State_Pattern.States;
using State_Pattern.Interfaces;
public class NoQuarterState : IGumBallMachineState
{
    private readonly GumBallMachine gumBallMachine;

    public NoQuarterState(GumBallMachine gumBallMachine)
    {
        this.gumBallMachine = gumBallMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter.");
        gumBallMachine.SetState(gumBallMachine.HasQuarterState);
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there's no quarter.");
    }

    public void Dispense()
    {
        Console.WriteLine("Insert Quarter First.");
    }
}