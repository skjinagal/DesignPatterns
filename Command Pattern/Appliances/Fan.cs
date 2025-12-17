namespace Command_Pattern.Appliances;
public class Fan
{
    // private int speed;
    private bool isOn;

    public void On()
    {
        Console.WriteLine("Fan is On");
        isOn = true;
    }

    public void Off()
    {
        Console.WriteLine("Fan is Off");
        isOn = false;
    }

    // public void SetSpeed(int speed)
    // {
    //     // Code to set the fan speed
    // }
}