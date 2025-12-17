namespace Command_Pattern.Commands;
public interface ICommand
{
    void Execute();
    void Undo();
}