namespace pet_project.net.Tasks.Domain.Entities;

public class TaskItem : BaseAuditableEntity
{
    public Guid TrackerId { get; set; }
    public string? Title { get; set; }
    public string? Note { get; set; }
    public PriorityLevel Priority { get; set; } = PriorityLevel.None;
    public TaskStatus Status { get; set; } = TaskStatus.ToDo;
}