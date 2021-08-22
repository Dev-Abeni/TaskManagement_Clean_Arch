using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Domain.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IEnumerable<TaskModel>> GetAllTasks()
        {
            return await _taskService.GetAllTasks();
        }

        [HttpPut]
        public Task<TaskModel> UpdateTask(TaskModel task)
        {
            return (Task<TaskModel>)_taskService.UpdateTask(task);
        }

        [HttpPost]
        public void AddTask(TaskModel task)
        {
            _taskService.Add(task);
        }
    }
}
