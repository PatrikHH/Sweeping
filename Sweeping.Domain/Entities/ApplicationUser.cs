using Microsoft.AspNetCore.Identity;

namespace Sweeping.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public string? DisplayName { get; set; } = null;

    public DateTime CreatedAt { get; set; }

    public ICollection<HouseholdMember> HouseholdMemberships { get; set; } = [];
}
