using Command_Pattern.Appliances;
namespace Command_Pattern.Commands;
public class FanOffCommand : ICommand
{
    private Fan fan;
    private int previousSpeed;

    public FanOffCommand(Fan fan)
    {
        this.fan = fan;
    }

    public void Execute()
    {
        // previousSpeed = fan.GetSpeed();
        fan.Off();
    }

    public void Undo()
    {
        fan.On();
    }
}