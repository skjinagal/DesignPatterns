namespace State_Pattern;
using State_Pattern.Interfaces;
using State_Pattern.States;
public class GumBallMachine
{
    public IGumBallMachineState OutOfGumBallState { get; private set; }
    public IGumBallMachineState NoQuarterState { get; private set; }
    public IGumBallMachineState HasQuarterState { get; private set; }
    public IGumBallMachineState GumBallSoldState { get; private set; }

    private IGumBallMachineState currentState;
    private int count;

    public GumBallMachine(int numberOfGumBalls)
    {
        OutOfGumBallState = new OutOfGumBallState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        GumBallSoldState = new GumBallSoldState(this);
        count = numberOfGumBalls;
        if (numberOfGumBalls > 0)
        {
            currentState = new NoQuarterState(this);
        }
        else
        {
            currentState = new OutOfGumBallState(this);
        }
    }

    public void InsertQuarter()
    {
        currentState.InsertQuarter();
    }

    public void EjectQuarter()
    {
        currentState.EjectQuarter();
    }

    public void TurnCrank()
    {
        currentState.TurnCrank();
        currentState.Dispense();
    }

    public void SetState(IGumBallMachineState state)
    {
        currentState = state;
    }

    public void ReleaseBall()
    {
        if (count > 0)
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            count--;
        }
    }

    public int GetCount()
    {
        return count;
    }
}