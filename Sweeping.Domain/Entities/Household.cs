namespace Sweeping.Domain.Entities;

public class Household
{
    public Guid HouseholdId { get; set; }

    public string Name { get; set; } = null!;

    public Guid CreatedByUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public ApplicationUser? CreatedByUser { get; set; } = null;

    public ICollection<HouseholdMember> Members { get; set; } = [];

    public ICollection<Room> Rooms { get; set; } = [];
}
