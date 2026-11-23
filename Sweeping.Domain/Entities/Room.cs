namespace Sweeping.Domain.Entities;
public class Room
{
    public Guid RoomId { get; set; }

    public Guid HouseholdId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public Household? Household { get; set; } = null;

    public ICollection<CleaningTask> Tasks { get; set; } = [];
}
