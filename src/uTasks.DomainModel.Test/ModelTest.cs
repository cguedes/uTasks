using System;
using System.Collections.Generic;
using System.Data.Entity.Database;
using System.Drawing;
using System.Linq;
using System.Text;

namespace uTasks.DomainModel.Test
{
    public class ModelTest
    {

        [NUnit.Framework.TestCase]
        public void Should_Create_Database_From_TasksContext()
        {
            using (var ctx = new TasksContext())
            {
                ctx.Categories.Add(new Category() {Color = Color.Red, Name = "ISEL"});
                ctx.SaveChanges();
            }
            
        }

    }
}
