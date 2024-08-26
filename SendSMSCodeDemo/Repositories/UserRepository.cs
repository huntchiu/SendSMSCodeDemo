using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SendSMSCodeDemo.Data;

namespace SendSMSCodeDemo.Repositories
{
    public class UserRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public UserRepository(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }


        // 查詢所有用戶
        public IQueryable<IdentityUser> GetAllUsers()
        {
            return _userManager.Users;
        }

        // 查詢所有用戶
        public async Task<IEnumerable<IdentityUser>> GetAllUsersAsync()
        {
            return await _userManager.Users.ToListAsync();
        }


        // 根據用戶ID獲取用戶信息
        public async Task<IdentityUser?> GetUserByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }


        // 更新用戶信息
        public async Task<IdentityResult> UpdateUserAsync(IdentityUser user)
        {
            return await _userManager.UpdateAsync(user);
        }

        // 刪除用戶
        public async Task<IdentityResult> DeleteUserAsync(IdentityUser user)
        {
            return await _userManager.DeleteAsync(user);
        }
    }
}
