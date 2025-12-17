
using State_Pattern.Interfaces;
namespace State_Pattern.States;
public class OutOfGumBallState : IGumBallMachineState
{
    private readonly GumBallMachine gumBallMachine;

    public OutOfGumBallState(GumBallMachine gumBallMachine)
    {
        this.gumBallMachine = gumBallMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert a quarter, the machine is out of gumballs.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there are no gumballs.");
    }
    public void Dispense()
    {
        Console.WriteLine("can not dispense");
    }
}