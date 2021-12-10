using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.ProjectAggregate;

namespace Infrastructure
{
    public class ProjectRepository : IRepository<Project> 
    {
        public Task<Project> GetById(int id)
        {
            var project = new Project("Foo") { Id = 1 };

            project.AddItem(new ToDoItem() { Id = 1, Title = "ToDo_1", Description = "Example Task 1" });
            project.AddItem(new ToDoItem() { Id = 2, Title = "ToDo_2", Description = "Example Task 2" });
            project.AddItem(new ToDoItem() { Id = 3, Title = "ToDo_3", Description = "Example Task 3" });
            project.AddItem(new ToDoItem() { Id = 4, Title = "ToDo_4", Description = "Example Task 4" });

            return Task.FromResult(project);
        }
    }
}
