
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
    private JsonValue Value { get; set; }


    public JValue()
    {
        Type = JType.Null; 
    } 

    public JValue(bool value)
    {
        Type = JType.Bool;
        Value = new JsonBool { Value = value };
    }
    
    public JValue(double value)
    {
        Type = JType.Number;
        Value = new JsonNumber { Value = value };
    }

    public JValue(string value)
    {
        Type = JType.String;
        Value = new JsonString { Value = value };
    }

    public JValue(List<JsonValue> values)
    {
        Type = JType.Array;
        Value = new JsonArray {Values = values};
    }

    public JValue(Dictionary<string, JsonValue> values)
    {
        Type = JType.Object;
        Value = new JsonArray {Values = values};
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
            return ((JsonBool)Value).Value;
        }
        set 
        {
            Type = JType.Bool;
            Value = new JsonBool { Value = value };
        }
    }

    public double Number 
    {
        get 
        {
            if (Type != JType.Number) throw new CastException();
            return ((JsonNumber)Value).Value;
        }
        set 
        {
            Type = JType.Number;
            Value = new JsonNumer { Value = value };
        }
    }
    
    public string String 
    {
        get 
        {
            if (Type != JType.String) throw new CastException();
            return ((JsonString)Value).Value;
        }
    }

    public List<JValue> Array 
    {
        get 
        {
            if (Type != JType.Array) throw new CastException();
            return ((JsonArray)Value).Values;
        }
        set 
        {
            Type = JType.Array;
            Value = new JsonValue { Values = value; }
        }
    }

    public Dictionary<string, JValue> Object 
    {
        get 
        {
            if (Type != JType.Dictionary) throw new CastException();
            return ((JsonDictionary)Value).Values;
        }
        set 
        {
            Type = JType.Dicionary;
            Value = new JsonDictionary { Values = value; }
        }
    }

    public JValue this[string key]
    {
        get { return Object[key]; }
        set { return Object[key] = value; }
    }
    
    public int Count 
    {
        get { return Array.Count; }
    }

    public JValue this[int index]
    {
        get { return Array[index]; }
        set { Array[index] = value; }
    }

}



private class JsonValue
{
}

private class JsonBool : JsonValue
{
    public bool Value;
}

private class JsonNumber : JsonValue
{
    public double Value;
}

private class JsonString : JsonValue
{
    public string Value;
}

private class JsonArray : JsonValue
{
    public List<JValue> Values;
}

private class JsonObject : JsonValue
{
    public Dicionary<string, JValue> : Values;
}

