using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SendSMSCodeDemo.Data;
using SendSMSCodeDemo.Models.DTOs;

namespace SendSMSCodeDemo.Repositories
{
    public class AccountRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        public AccountRepository(ApplicationDbContext dbContext ,UserManager<IdentityUser> userManager )
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public  async Task<IdentityResult> RegisterAsync(IdentityUser user ,string password)
        {
           return await _userManager.CreateAsync(user,password);
        }

        public async Task<bool> UserExistsByPhoneNumberAsync(string phoneNumber)
        {
            return await _userManager.Users.AnyAsync(u => u.PhoneNumber == phoneNumber);
        }
        
    }
}