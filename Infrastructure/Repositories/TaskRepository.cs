using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly SirayeDbConext _context;

        public TaskRepository(SirayeDbConext context)
        {
            _context = context;
        }

        public void AddTask(TaskModel task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public async Task<List<TaskModel>> GetAllTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TaskModel> GetById(Guid id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<TaskModel> Update(TaskModel task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();

            return task;
        }
    }
}
