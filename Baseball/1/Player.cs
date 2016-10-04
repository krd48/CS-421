
public class Player {
    public int Hand { // 0 -> Left, 1 -> Right, 2 -> Switch
        get;
        set {
            if(value < 0 || value > 2)
                throw new ArgumentException("The value must be either 0, 1, or 2.");
            hand = value;
        }
    }
    
    public string Name {
        get;
        set;
    }
    
    public DateTime DoB {
        get;
        set;
    }

    public float Number {
        get;
    }
}
