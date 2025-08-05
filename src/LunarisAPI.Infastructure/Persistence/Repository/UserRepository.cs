using LunarisAPI.App.Interfaces;
using LunarisAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarisAPI.Infastructure.Persistence.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext;
        public UserRepository(AppDbContext _dbContext)
        {
            appDbContext = _dbContext;
        }

        public async Task BanAsync(long UserID)
        {
            
            var user = new User { UserId = UserID, isBanned = true };
            appDbContext.Users.Attach(user);
            appDbContext.Entry(user).Property(u => u.isBanned).IsModified = true;
            await Task.CompletedTask;
        }

        public void Delete(User user)
        {
            appDbContext.Users.Remove(user);
        }

        public async Task InsertAsync(User user)
        {
            await appDbContext.Users.AddAsync(user);
        }

        public async Task<int> SaveChangesAsync()
        {
           return  await appDbContext.SaveChangesAsync();
        }

        public IQueryable<User> SelectAll()
        {
            return appDbContext.Users;
        }

        public async Task<User?> SelectByIdAsync(long UserId)
        {
            var user = await appDbContext.Users.FirstOrDefaultAsync(u => u.UserId == UserId);

            return user;
        }

        public void  Update(User user)
        {
            appDbContext.Users.Update(user);
        }
    }
}
