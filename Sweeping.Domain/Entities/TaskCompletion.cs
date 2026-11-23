namespace Sweeping.Domain.Entities;
public class TaskCompletion
{
    public Guid CompletionId { get; set; }

    public Guid HouseholdId { get; set; }

    public Guid TaskId { get; set; }

    public Guid CompletedByUserId { get; set; }

    public DateTime CompletedAt { get; set; }

    public string? Note { get; set; }

    public CleaningTask? Task { get; set; } = null;

    public ApplicationUser? CompletedByUser { get; set; } = null;
}