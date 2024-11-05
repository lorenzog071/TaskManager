using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        public TaskController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var tasks = _dbContext.Tasks.ToList();
            var model = new TaskListViewModel
            {
                Tasks = new List<TaskListModel>()
            };
            foreach(var task in tasks)
            {
                model.Tasks.Add(new TaskListModel
                {
                    Name = task.Name,
                    Descripcion = task.Descripcion,
                    TaskPriority = (TaskListModel.Priority)task.TaskPriority
                });
            }
            return View("ListTasks", model);
        }
    }
}