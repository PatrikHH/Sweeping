using Sweeping.Domain.Enums.HouseholdRole;

namespace Sweeping.Domain.Entities;
public class HouseholdMember
{
    public Guid HouseholdId { get; set; }

    public Guid UserId { get; set; }

    public HouseholdRole Role { get; set; }

    public DateTime JoinedAt { get; set; }

    public Household? Household { get; set; } = null;

    public ApplicationUser? User { get; set; } = null;
}
