namespace Command_Pattern.Appliances;
public class Stereo
{
    private bool isOn;
    private int volume;

    public void On()
    {
        isOn = true;
    }

    public void Off()
    {
        isOn = false;
    }

    public void SetVolume(int volume)
    {
        this.volume = volume;
    }
}