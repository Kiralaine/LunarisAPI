using LunarisAPI.App.Interfaces;
using LunarisAPI.Domain.Entities;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public IQueryable<User> SelectAll()
        {
            throw new NotImplementedException();
        }

        public async Task<User?> SelectByIdAsync(long UserId)
        {
            throw new NotImplementedException();
        }

        public void  Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
