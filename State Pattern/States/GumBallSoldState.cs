
using State_Pattern.Interfaces;
namespace State_Pattern.States;
public class GumBallSoldState : IGumBallMachineState
{
    private readonly GumBallMachine gumBallMachine;

    public GumBallSoldState(GumBallMachine gumBallMachine)
    {
        this.gumBallMachine = gumBallMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank.");
    }

    public void TurnCrank() 
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
    }   

    public void Dispense()
    {
        gumBallMachine.ReleaseBall();
        if (gumBallMachine.GetCount() > 0)
        {
            gumBallMachine.SetState(gumBallMachine.NoQuarterState);
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs!");
            gumBallMachine.SetState(gumBallMachine.OutOfGumBallState);
        }
    }

}