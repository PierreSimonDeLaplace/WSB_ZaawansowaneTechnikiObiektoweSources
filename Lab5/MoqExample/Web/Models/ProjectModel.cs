using System.Collections.Generic;

namespace Web.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<ToDoItemModel> Items = new();
    }
}