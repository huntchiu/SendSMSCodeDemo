using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SendSMSCodeDemo.Models.Responses
{
    public class EmployeeResponseModel
    {

        public Guid Id { get; set; }
        public string? Name { get; set; }

        [JsonPropertyName("birth_date")]
        public DateTime BirthDate { get; set; }
    }
}