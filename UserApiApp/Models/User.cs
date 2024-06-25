using System;
using System.Text.Json.Serialization;

namespace UserApiApp.Models
{
    public class User
    {
        public UserName UserName { get; set; }
        public string MatriculationId { get; set; }
        public string Email { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime DateAndTimings { get; set; }

        public string YoutubeVideoLink { get; set; }
        public string Place { get; set; }
        public MapCoordinates Map { get; set; }
    }

    public class UserName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class MapCoordinates
    {
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
