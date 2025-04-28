using Ardalis.GuardClauses;
using ETU.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace ETU.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>, ISoftDelete
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;

        public DateTime? DeletedAt { get; private set; }
        public bool IsDeleted => DeletedAt.HasValue;

        public AppUser(string firstName, string lastName, string email)
        {
            FirstName = Guard.Against.NullOrWhiteSpace(firstName, nameof(firstName));
            LastName = Guard.Against.NullOrWhiteSpace(lastName, nameof(lastName));
            Email = Guard.Against.NullOrWhiteSpace(email, nameof(email));
            UserName = email;
        }

        public void MarkAsDeleted()
        {
            if (IsDeleted)
                throw new InvalidOperationException("User is already deleted.");

            DeletedAt = DateTime.UtcNow;
        }
    }
}