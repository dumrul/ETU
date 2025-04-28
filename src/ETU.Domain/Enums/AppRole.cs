using Ardalis.SmartEnum;

namespace ETU.Domain.Enums
{
    public sealed class AppRole : SmartEnum<AppRole>
    {
        public static readonly AppRole Admin = new(nameof(Admin), 1);
        public static readonly AppRole User = new(nameof(User), 2);

        private AppRole(string name, int value) : base(name, value)
        {
        }
    }
}