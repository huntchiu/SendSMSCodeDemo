using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSCodeDemo.Models.DTOs
{
    public class RegisterDTO
    {
        public string PhoneNumber { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}