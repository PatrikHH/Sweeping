using Sweeping.Domain.Enums.HouseholdRole;

namespace Sweeping.Domain.Entities;
public class TaskSchedule
{
    public Guid TaskScheduleId { get; set; }

    public Guid HouseholdId { get; set; }

    public Guid TaskId { get; set; }

    public bool IsRecurring { get; set; }

    public RecurrenceType? RecurrenceType { get; set; }

    public int? IntervalDays { get; set; }

    public DateOnly? NextDueDate { get; set; }

    public DateTime? LastCompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public CleaningTask? Task { get; set; } = null;
}