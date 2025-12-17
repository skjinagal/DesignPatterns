namespace State_Pattern.Interfaces;
public interface IGumBallMachineState
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();
}