using System.Text.Json.Serialization;

namespace Logus.SupportPage.Data.Dtos
{
    public class UserCreateDto
    {
        [JsonPropertyName("firstname")]
        public string? FirstName { get; set; }
        [JsonPropertyName("lastname")]
        public string? LastName { get; set; }
        [JsonPropertyName("middlename")]
        public string? MiddleName { get; set; }
        [JsonPropertyName("login")]
        public string? Login { get; set; }
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        [JsonPropertyName("organization")]
        public string? Organization { get; set; }

    }
}
