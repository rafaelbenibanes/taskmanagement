using TaskManagement.Core.Entities;

namespace TaskManagement.Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<TaskEntity> GetByIdAsync(int id);
        Task<IEnumerable<TaskEntity>> GetAllAsync();
        Task AddAsync(TaskEntity task);
        Task UpdateAsync(TaskEntity task);
        Task DeleteAsync(int id);
    }
}