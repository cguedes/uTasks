using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;

namespace uTasks.DomainModel
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public Color Color { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }

    public class Task
    {
        public int TaskId { get; set; }

        public string   What { get; set; }
        public DateTime When { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }

    public class SimpleTask : Task
    {
        
    }

    public class CompositeTask : Task
    {
        public virtual ICollection<Task> Tasks { get; set; }
    }



    public class TasksContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Task>     Tasks      { get; set; }

        protected override void OnModelCreating(System.Data.Entity.ModelConfiguration.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}
