namespace Sweeping.Domain.Entities;
public class CleaningTask
{
    public Guid TaskId { get; set; }

    public Guid HouseholdId { get; set; }

    public Guid RoomId { get; set; }

    public string? Title { get; set; } = null;

    public string? Description { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public Room? Room { get; set; } = null;

    public Household? Household { get; set; } = null;

    public ApplicationUser? CreatedByUser { get; set; } = null;

    public TaskSchedule? Schedule { get; set; } = null;

    public ICollection<TaskCompletion> Completions { get; set; } = [];
}
