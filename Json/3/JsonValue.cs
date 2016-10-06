

public enum JType
{
    Null,
    Bool,
    Number,
    String,
    Array,
    Object,
}

public class JValue
{
    public JType Type { get; private set; }
    private object Value { get; set; }


    public JValue()
    {
        Type = JType.Null; 
    } 

    public JValue(bool value)
    {
        Type = JType.Bool;
        Value = value;
    }
    
    public JValue(double value)
    {
        Type = JType.Number;
        Value = value;
    }

    public JValue(string value)
    {
        Type = JType.String;
        Value = value;
    }

    public JValue(List<JsonValue> values)
    {
        Type = JType.Array;
        Value = values;
    }

    public JValue(Dictionary<string, JsonValue> values)
    {
        Type = JType.Object;
        Value = values;
    }

    public bool Null 
    {
        get { return Type == JType.Null; }
        set { Type = JType.Null; Value = null; }
    }

    public bool Bool 
    {
        get 
        {
            if (Type != JType.Bool) throw new CastException();
            return (bool)Value;
        }
        set 
        {
            Type = JType.Bool;
            Value = value;
        }
    }

    public double Number 
    {
        get 
        {
            if (Type != JType.Number) throw new CastException();
            return (double)Value;
        }
        set 
        {
            Type = JType.Number;
            Value = value;
        }
    }
    
    public string String 
    {
        get 
        {
            if (Type != JType.String) throw new CastException();
            return (string)Value;
        }
        set 
        {
            Type = JType.String;
            Value = value;
        }
    }

    public List<JsonValue> Array 
    {
        get 
        {
            if (Type != JType.Array) throw new CastException();
            return (List<JValue>)Value;
        }
        set 
        {
            Type = JType.Array;
            Value = value;
        }
    }

    public Dictionary<string, JValue> Array 
    {
        get 
        {
            if (Type != JType.Dictionary) throw new CastException();
            return (Dictionary<Value>)Value;
        }
        set 
        {
            Type = JType.Dicionary;
            Value = value;
        }
    }
}

