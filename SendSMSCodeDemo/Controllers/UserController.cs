using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SendSMSCodeDemo.Models.Responses;
using SendSMSCodeDemo.Services;

namespace SendSMSCodeDemo.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly UserService _userService;

        public UserController( IMapper mapper, UserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }
        
        
        [HttpGet]
        public async  Task<ActionResult<IEnumerable<UserResponseModel>>> Get()
        {
            var users = await _userService.GetAllUsersAsync();
            var response = _mapper.Map<IEnumerable<UserResponseModel>>(users);
            return Ok(response);


        }


    }
}