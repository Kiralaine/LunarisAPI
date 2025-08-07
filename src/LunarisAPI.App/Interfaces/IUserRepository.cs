using LunarisAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarisAPI.App.Interfaces
{
    public  interface IUserRepository
    {
        public Task<User?> SelectByIdAsync(long UserId);
        public IQueryable<User> SelectAll();
        public Task InsertAsync(User user);
        Task<ICollection<User>> SelectAllAsync();

        public  void Update(User user);
        public void Delete(User user);
        public Task BanAsync(long UserID);
        public Task<int> SaveChangesAsync();
    }
}
