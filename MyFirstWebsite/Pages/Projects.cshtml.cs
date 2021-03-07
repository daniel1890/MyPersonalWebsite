using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyFirstWebsite.Models;
using MyFirstWebsite.Services;

namespace MyFirstWebsite.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly ILogger<ProjectsModel> _logger;
        public JsonFileProjectService ProjectService;
        public IEnumerable<Project> Projects1 { get; private set; }

        public ProjectsModel(ILogger<ProjectsModel> logger, JsonFileProjectService projectService)
        {
            _logger = logger;
            ProjectService = projectService;
        }

        public void OnGet()
        {
            Projects1 = ProjectService.GetProjects();
        }
    }
}