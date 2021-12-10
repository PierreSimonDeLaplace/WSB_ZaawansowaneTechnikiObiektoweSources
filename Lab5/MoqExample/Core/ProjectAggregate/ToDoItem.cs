namespace Core.ProjectAggregate
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsDone { get; private set; }

        public void MarkComplete()
        {
            if (!IsDone)
            {
                IsDone = true;
            }
        }

        public override string ToString()
        {
            string status = IsDone ? "Done!" : "Not done.";
            return $"{Id}: Status: {status} - {Title} - {Description}";
        }
    }
}
