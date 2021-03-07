using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyFirstWebsite.Models;
using MyFirstWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileProjectService ProjectService1;
        public IEnumerable<Project> Projects { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProjectService projectService)
        {
            _logger = logger;
            ProjectService1 = projectService;
        }

        public void OnGet()
        {
            Projects = ProjectService1.GetProjects();
        }
    }
}