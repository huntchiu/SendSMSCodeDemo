using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SendSMSCodeDemo.Models;
using SendSMSCodeDemo.Models.DTOs;
using SendSMSCodeDemo.Models.Entities;
using SendSMSCodeDemo.Models.Requests;
using SendSMSCodeDemo.Models.Responses;
using SendSMSCodeDemo.Services;

namespace SendSMSCodeDemo.Controllers
{

    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : GenericController<Employee, EmployeeDTO, EmployeeRequestModel, EmployeeResponseModel>
    {
        public EmployeeController(GenericService<Employee, EmployeeDTO> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}