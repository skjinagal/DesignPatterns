using Command_Pattern.Commands;
namespace Command_Pattern;
public class RemoteControlSystem
{
    private ICommand[] onCommands;
    private ICommand[] offCommands;

    private ICommand undo;
    public RemoteControlSystem()
    {
        onCommands = new ICommand[7];
        offCommands = new ICommand[7];
        for(int i =0; i<7; i++)
        {
            onCommands[i] = new NoCommand();
            offCommands[i] = new NoCommand();
        }
        undo = new NoCommand();
    }
    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }
    public void OnButtonPressed(int slot)
    {
        onCommands[slot].Execute();
        undo = onCommands[slot];
    }
    public void OffButtonPressed(int slot)
    {
        offCommands[slot].Execute();
        undo = offCommands[slot];
    }

    public void UndoButtonPressed()
    {
        undo.Undo();
    }
}