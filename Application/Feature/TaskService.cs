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
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void Add(TaskModel task)
        {
            _taskRepository.AddTask(task);
        }

        public async Task<List<TaskModel>> GetAllTasks()
        {
            return await _taskRepository.GetAllTasks();
        }

        public async Task UpdateTask(TaskModel task)
        {
            await _taskRepository.Update(task);
        }
    }
}
