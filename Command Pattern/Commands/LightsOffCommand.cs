using Command_Pattern.Appliances;
namespace Command_Pattern.Commands;
public class LightsOffCommand : ICommand
{
    private readonly Lights lights; 
    public LightsOffCommand(Lights lights)
    {
        this.lights = lights;
    }
    public void Execute()
    {
        lights.Off();
    }
    public void Undo()
    {
        lights.On();
    }
}