using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Add(UserModel user)
        {
            UserModel userData = user;
            await _userRepository.AddUserAsync(userData);
            return userData.Id;
        }

        public Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
