
public enum Base
    {
        Home = 0,
        First = 1,
        Second = 2,
        Third  = 3,
        Bench = -1,
        Field = -2
    };

public enum Position
    {
        Batter,
        Fielder,
        Pitcher,
        Catcher
    };


class Players
{
    public string Name
    {
        get; set;
    }
    public DateTime DOB
    {
        get; set;
    }

    public Position Position
    {
        get; set;
    }

    public Base Base
    {
        get; set;
    }

}
