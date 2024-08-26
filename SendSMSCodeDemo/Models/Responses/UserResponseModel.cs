using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SendSMSCodeDemo.Models.Responses
{
    public class UserResponseModel
    {
        public Guid Id { get; set; }
        
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }
        
        public string? Email { get; set; }
        
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }
}

