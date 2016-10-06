
public class Program
{
    public static void Main()
    {
        var json = new JsonObject();
        json.Values["name"] = new JsonString() { Value = "Cam Newton" };
        json.Values["age"] = new JsonNumber() { Value = "26" };

    }

    public string ToString(JsonValue json)
    {
        if (json is JsonArray)
        {
            foreach (var value in ((JsonArray)json).values)
            {
                // ...
            }
        }

    }
}