using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.ProjectAggregate;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly IRepository<Project> _projectRepository;

        public ProjectController(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet()]
        public async Task<IActionResult> Index(int id = 1)
        {
            var project = await _projectRepository.GetById(id);
            if (project == null)
            {
                return NotFound();
            }

            var dto = new ProjectModel
            {
                Id = project.Id,
                Name = project.Name,
                Items = project.Items
                    .Select(item => ToDoItemModel.FromToDoItem(item))
                    .ToList()
            };

            return View(dto);
        }
    }
}