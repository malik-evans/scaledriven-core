namespace Scaledriven.Models
{

    public enum ProfileType
    {
        User,
        Page,
        Event
    }

    public class Profile
    {
        public string ProfileId { get; set; }

        public ProfileType ProfileType { get; set; }
    }
}
