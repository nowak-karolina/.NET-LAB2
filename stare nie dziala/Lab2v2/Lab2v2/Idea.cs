using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2v2 {
    internal class Idea : DbContext{
        public DbSet<ToDo> toDos {  get; set; }

        public Idea() {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite(@"Data Source=Ideas.db");
        }

    }


}
