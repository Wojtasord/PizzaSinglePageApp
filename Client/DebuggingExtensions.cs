using System.Text.Json;

namespace PizzaSinglePageApp.Client
{
    public static class DebuggingExtensions
    {
        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, obj.GetType());
    }
}