namespace Command_Pattern.Appliances;
public class GarageDoor
{
    private bool isOpen;

    public void Up()
    {
        Console.WriteLine("Garage Door is Open");
        isOpen = true;
    }

    public void Down()
    {
        Console.WriteLine("Garage Door is Closed");
        isOpen = false;
    }
}