namespace Command_Pattern.Appliances;
public class Lights
{
    private bool isOn;

    public void On()
    {
        Console.WriteLine("Lights are On");
        isOn = true;
    }

    public void Off()
    {
        Console.WriteLine("Lights are Off");
        isOn = false;
    }
}