using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ITaskService
    {
        Task<List<TaskModel>> GetAllTasks();
        void Add(TaskModel task);
        //Task<UserModel> GetUser(Guid id);
        Task UpdateTask(TaskModel task);
        //Task DeleteUser(Guid id);
    }
}
