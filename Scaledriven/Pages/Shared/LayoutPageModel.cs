using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Scaledriven.Pages.Shared
{
    public class StyleOptions
    {
        public readonly string height = "700";
    }

    public class LayoutPageModel : PageModel
    {
        public StyleOptions StyleOptions = new StyleOptions();

        public List<string> Messages { get; } = new List<string>
        {
            "Hello from scaledriven",
            "We demand pipilines on azure team devops"
        };

        public void OnGet()
        {

        }
    }
}
