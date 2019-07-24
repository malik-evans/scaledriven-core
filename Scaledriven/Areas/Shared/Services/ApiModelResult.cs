namespace Scaledriven.Areas.Shared.Services
{

    public class Link
    {
        public string Href { get; set; }
        public string Rel { get; set; }
        public string Type { get; set; }
    }

    public class Action
    {
        public string Method { get; set; }
        public string Url { get; set; }
    }
}
