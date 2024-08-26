using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SendSMSCodeDemo.Models.Requests
{
    public class RegisterRequestModel
    {
        [Required(ErrorMessage = "手机号码是必填項")]
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "密码是必填項")]
        public string Password { get; set; } = string.Empty;
    }
}