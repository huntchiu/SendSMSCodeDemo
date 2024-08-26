using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSCodeDemo.Models.DTOs
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        // public Guid DepartmentId { get; set; }
        // public DepartmentDTO? Department { get; set; }
    }
}