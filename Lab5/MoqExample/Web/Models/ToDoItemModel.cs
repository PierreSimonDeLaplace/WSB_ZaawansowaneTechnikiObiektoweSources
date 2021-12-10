using Core.ProjectAggregate;

namespace Web.Models
{
    public class ToDoItemModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; private set; }

        public static ToDoItemModel FromToDoItem(ToDoItem item)
        {
            return new ToDoItemModel()
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                IsDone = item.IsDone
            };
        }
    }
}