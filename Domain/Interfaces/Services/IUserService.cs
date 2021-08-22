using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsers();
        Task<Guid> Add(UserModel user);
        Task<UserModel> GetUser(Guid id);
        Task UpdateUser(UserModel user);
        Task DeleteUser(Guid id);
    }
}
