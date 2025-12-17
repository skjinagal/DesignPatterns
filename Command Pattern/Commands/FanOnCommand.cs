using Command_Pattern.Appliances;
namespace Command_Pattern.Commands;
public class FanOnCommand : ICommand
{
    private readonly Fan fan; 
    public FanOnCommand(Fan fan)
    {
        this.fan = fan;
    }
    public void Execute()
    {
        fan.On();
    }
    public void Undo()
    {
        fan.Off();
    }
}