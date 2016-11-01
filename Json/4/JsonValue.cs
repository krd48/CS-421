using System.Collections.Generic;

namespace MyApp
{


    internal abstract class JsonValue
    {
        public abstract string ToString(bool pretty);
    }

    internal class JsonBool : JsonValue
    {
        public bool Value;

        public override string ToString()
        {
            return Value ? "true" : "false";
        }

        public override string ToString(bool pretty)
        {
            return ToString();
        }
    }

    internal class JsonNumber : JsonValue
    {
        public double Value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public override string ToString(bool pretty)
        {
            return ToString();
        }
    }

    internal class JsonString : JsonValue
    {
        public string Value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public override string ToString(bool pretty)
        {
            return ToString();
        }
    }

    internal class JsonArray : JsonValue
    {
        public List<JValue> Values;

        public override string ToString()
        {
            return ToString(true);
        }

        public override string ToString(bool pretty)
        {
            var formatter = new JsonFormatter { Pretty = pretty };
            formatter.WriteArray(Values);
            return formatter.ToString();
        }
    }

    internal class JsonObject : JsonValue
    {
        public Dictionary<string, JValue> Values;

        public override string ToString()
        {
            return ToString(true);
        }

        public override string ToString(bool pretty)
        {
            var formatter = new JsonFormatter { Pretty = pretty };
            formatter.WriteObject(Values);
            return formatter.ToString();
        }
    }

    internal class JsonBlob : JsonValue
    {
        public byte[] Value;

        public override string ToString()
        {
            return System.Convert.ToBase64String(Value);
        }

        public override string ToString(bool pretty)
        {
            return ToString();
        }
    }

}
