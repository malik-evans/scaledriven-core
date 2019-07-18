using System.Collections.Generic;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.Services
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

    public class ApiModelResult : IActionResult
    {
        public List<Link> Links { get; set; }
        public List<Action> Actions { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            return Task.CompletedTask;
        }
    }
}
