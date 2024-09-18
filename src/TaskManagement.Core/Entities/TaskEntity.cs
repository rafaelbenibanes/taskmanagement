namespace TaskManagement.Core.Entities
{
    public class TaskEntity
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }

        public TaskEntity(string title, string description)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }
}