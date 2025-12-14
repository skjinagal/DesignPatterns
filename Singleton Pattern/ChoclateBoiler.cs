namespace Singleton_Pattern;
public class ChoclateBoiler
{
    private static ChoclateBoiler? instance;
    private bool empty;
    private bool boiled;

    private ChoclateBoiler()
    {
        empty = true;
        boiled = false;
    }

    public static ChoclateBoiler GetInstance()
    {
        if (instance == null)
        {
            instance = new ChoclateBoiler();
        }
        return instance;
    }

    public void Fill()
    {
        if (IsEmpty())
        {
            empty = false;
            boiled = false;
            // fill the boiler with a milk/chocolate mixture
        }
    }

    public void Drain()
    {
        if (!IsEmpty() && IsBoiled())
        {
            empty = true;
            boiled = false;
        }
    }
    public bool IsEmpty()
    {
        return empty;
    }

    public bool IsBoiled()
    {
        return boiled;
    }

    public void Boil()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            // bring the contents to a boil
            boiled = true;
        }
    }
}