using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SendSMSCodeDemo.Models.Entities;
using SendSMSCodeDemo.Models;

namespace SendSMSCodeDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 創建默認用戶
            var defaultUser = new IdentityUser
            {
                UserName = "admin",
                Email = "admin@example.com",
            };
            // 添加默認用戶到數據庫
            modelBuilder.Entity<IdentityUser>().HasData(defaultUser);

        }
    }
}

