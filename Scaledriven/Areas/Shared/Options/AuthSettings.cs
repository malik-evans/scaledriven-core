namespace Scaledriven.Areas.Shared.Options
{
    public class AuthSettings
    {
        public readonly AuthInfo Info;
    }

    public class AuthInfo
    {
        public readonly string Issuer;
        public readonly string Audience;
        public readonly bool AutomaticAuthenticate;
        public readonly string Secret;
    }
}
