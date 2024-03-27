using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App {
    internal class ToDoDataBase : DbContext {
        public DbSet<ToDo> todos { get; set; }
        public ToDoDataBase() { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite(@"Data Source=Ideas.db");
        }
    }
}
