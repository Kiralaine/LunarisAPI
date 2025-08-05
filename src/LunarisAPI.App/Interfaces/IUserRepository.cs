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
        Task<User?> SelectByIdAsync(long UserId);
        IQueryable<User> SelectAll();
        Task InsertAsync(User user);
        void Update(User user);
        void Delete(User user);
        Task BanAsync(long UserID);
        Task<int> SaveChangesAsync();
    }
}
