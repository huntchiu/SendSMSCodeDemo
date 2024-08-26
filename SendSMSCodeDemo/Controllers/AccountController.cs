using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SendSMSCodeDemo.Models.DTOs;
using SendSMSCodeDemo.Models.Requests;
using SendSMSCodeDemo.Services;

namespace SendSMSCodeDemo.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;
        private readonly AccountService _accountService;

        public AccountController(UserManager<IdentityUser> userManager, IMapper mapper, AccountService accountService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _accountService = accountService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestModel model)
        {

            var registerDTO = _mapper.Map<RegisterDTO>(model);
            var identityResult = await _accountService.RegisterAsync(registerDTO);

            if (!identityResult.Succeeded)
            {
                return BadRequest(identityResult.Errors);
            }

            return Ok();
        }

    }
}