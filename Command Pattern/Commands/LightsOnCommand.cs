using Command_Pattern.Appliances;
namespace Command_Pattern.Commands;

public class LightsOnCommand : ICommand
{
    private readonly Lights lights;

    public LightsOnCommand(Lights lights)
    {
        this.lights = lights;
    }

    public void Execute()
    {
        lights.On();
    }

    public void Undo()
    {
        lights.Off();
    } 
}