using TaskManagement.Application.Requests;
using TaskManagement.Application.Responses;
using TaskManagement.Core.Entities;

namespace TaskManagement.Application.Mappers
{
    public static class TaskMapper
    {
        public static TaskEntity ToEntity(TaskCreateRequest request)
            => new TaskEntity(request.Title, request.Description);

        public static TaskResponse ToResponse(TaskEntity entity)
        {
            return new TaskResponse
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                IsCompleted = entity.IsCompleted
            };
        }

        public static IEnumerable<TaskResponse> ToResponseList(IEnumerable<TaskEntity> entities)
            => entities.Select(ToResponse);
    }
}