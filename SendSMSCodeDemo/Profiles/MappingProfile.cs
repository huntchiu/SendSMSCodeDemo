using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SendSMSCodeDemo.Models.DTOs;
using SendSMSCodeDemo.Models.Entities;
using SendSMSCodeDemo.Models.Requests;
using SendSMSCodeDemo.Models.Responses;

namespace SendSMSCodeDemo.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // 员工
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EmployeeRequestModel, EmployeeDTO>();
            CreateMap<EmployeeDTO, EmployeeResponseModel>();

            // 账号
            CreateMap<IdentityUser, RegisterDTO>().ReverseMap();
            CreateMap<RegisterRequestModel, RegisterDTO>();


            // 用户
            CreateMap<IdentityUser, UserDTO>().ReverseMap();
            CreateMap<UserDTO, UserResponseModel>();

        }
    }
}