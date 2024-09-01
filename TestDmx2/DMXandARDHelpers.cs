using System.Collections.Generic;
using System.Text.Json;
using TestDmx2.Models;

internal static class DMXandARDHelpers
{
    public static List<DMXfixture> Clone(List<DMXfixture> source)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize<List<DMXfixture>>(source, options);
        return (List<DMXfixture>)JsonSerializer.Deserialize<List<DMXfixture>>(jsonString);
    }
}