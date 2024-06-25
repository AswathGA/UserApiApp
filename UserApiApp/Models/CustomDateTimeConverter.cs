using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UserApiApp.Models
{
    public class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        private readonly string _dateFormat = "yyyy-MM-dd HH:mm";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (DateTime.TryParseExact(reader.GetString(), _dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return date;
            }
            throw new JsonException($"Unable to convert \"{reader.GetString()}\" to {typeof(DateTime)}.");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(_dateFormat, CultureInfo.InvariantCulture));
        }
    }
}
