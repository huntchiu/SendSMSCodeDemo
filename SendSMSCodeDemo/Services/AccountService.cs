using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SendSMSCodeDemo.Models.DTOs;
using SendSMSCodeDemo.Repositories;

namespace SendSMSCodeDemo.Services
{
    public class AccountService
    {
        private readonly AccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountService(AccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDTO model)
        {
            var userExists = await _accountRepository.UserExistsByPhoneNumberAsync(model.PhoneNumber);
            if (userExists)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Description = "Phone number already exists."
                });
            }

            var user = _mapper.Map<IdentityUser>(model);
            user.UserName = user.PhoneNumber;
            var identityResult = await _accountRepository.RegisterAsync(user, model.Password);
            return identityResult;
        }
    }
}