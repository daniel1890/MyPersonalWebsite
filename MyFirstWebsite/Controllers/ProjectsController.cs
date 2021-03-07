using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebsite.Models;
using MyFirstWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebsite.Controllers
{
    [Route("ProjectsTest")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        public ProjectsController(JsonFileProjectService projectService)
        {
            this.ProjectService = projectService;
        }

        public JsonFileProjectService ProjectService { get; }

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return ProjectService.GetProjects();
        }
    }
}