using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SirayeDbConext _context;

        public UserRepository(SirayeDbConext sirayeDbContext)
        {
            _context = sirayeDbContext;
        }

        public async Task<UserModel> AddUserAsync(UserModel user)
        {
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
