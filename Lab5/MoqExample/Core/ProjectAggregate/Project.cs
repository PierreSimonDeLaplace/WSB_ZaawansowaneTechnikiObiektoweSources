using System;
using System.Collections.Generic;

namespace Core.ProjectAggregate
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; private set; }

        private List<ToDoItem> items = new List<ToDoItem>();
        public IEnumerable<ToDoItem> Items => items.AsReadOnly();

        public Project(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name can not be null or empty");
            }

            this.Name = name;
        }

        public void AddItem(ToDoItem newItem)
        {
            if(newItem == null)
            {
                throw new ArgumentNullException(nameof(newItem), "ToDoItem can not be null");
            }

            this.items.Add(newItem);
        }
    }
}
