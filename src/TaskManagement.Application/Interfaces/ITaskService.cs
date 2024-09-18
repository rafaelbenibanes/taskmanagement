using TaskManagement.Application.Requests;
using TaskManagement.Core.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskEntity>> GetAllTasksAsync();
        Task<TaskEntity> GetTaskByIdAsync(int id);
        Task AddTaskAsync(TaskCreateRequest request);
        Task UpdateTaskAsync(TaskEntity task);
        Task DeleteTaskAsync(int id);
    }
}
