using System.IO;
using System.Text.Json;

namespace EntityManager.Utility
{
    public static class DataParser
    {
        public static void Serialize(string filePath, object input)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string serializedData = JsonSerializer.Serialize(input, options);
            File.WriteAllText(filePath, serializedData);
        }

        public static T? Deserialize<T>(string filePath)
        {
            string serializedData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(serializedData);
        }
    }
}