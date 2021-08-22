using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infrastructure.Context
{
    public class SirayeDbConext : DbContext
    {
        public SirayeDbConext(DbContextOptions<SirayeDbConext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
