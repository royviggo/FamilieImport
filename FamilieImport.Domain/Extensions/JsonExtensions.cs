using System.Text.Json;

namespace FamilieImport.Domain.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJsonData(this object entity)
        {
            return JsonSerializer.Serialize(entity);
        }
    }
}
