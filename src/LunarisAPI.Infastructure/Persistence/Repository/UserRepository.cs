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
        Task IUserRepository.BanAsync(long UserID)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Delete(User user)
        {
            throw new NotImplementedException();
        }

        Task IUserRepository.InsertAsync(User user)
        {
            throw new NotImplementedException();
        }

        Task<int> IUserRepository.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        IQueryable<User> IUserRepository.SelectAll()
        {
            throw new NotImplementedException();
        }

        Task<User?> IUserRepository.SelectByIdAsync(long UserId)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
