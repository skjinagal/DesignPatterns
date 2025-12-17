using Command_Pattern.Appliances;
namespace Command_Pattern.Commands;
public class GarageDoorOnCommand : ICommand
{
    private GarageDoor garageDoor;

    public GarageDoorOnCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public void Execute()
    {
        garageDoor.Up();
    }

    public void Undo()
    {
        garageDoor.Down();
    }
}