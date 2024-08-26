using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SendSMSCodeDemo.Models.Requests
{
    public class EmployeeRequestModel
    {
        
        [Required(ErrorMessage = "姓名是必填項")]
        public string Name { get; set; } = string.Empty;


        [JsonPropertyName("birth_date")]
        public DateTime? BirthDate { get; set; }
    }
}