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
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(UserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            var result = _mapper.Map<IEnumerable<UserDTO>>(users);
            return result;
        }

    }
}