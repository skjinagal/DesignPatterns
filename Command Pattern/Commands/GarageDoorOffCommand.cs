using Command_Pattern.Appliances;
namespace Command_Pattern.Commands;
public class GarageDoorOffCommand : ICommand
{
    private GarageDoor garageDoor;

    public GarageDoorOffCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public void Execute()
    {
        garageDoor.Down();
    }

    public void Undo()
    {
        garageDoor.Up();
    }
}