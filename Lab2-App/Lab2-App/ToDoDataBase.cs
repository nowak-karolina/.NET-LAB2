using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace App {
    internal class ToDoDataBase : DbContext {
        public DbSet<ToDo> todos { get; set; }
        public ToDoDataBase() { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite(@"Data Source=Ideas.db");
        }

        public override string ToString() {
            string s = " ";
            foreach (var item in todos) {
                s+= $"activity: {item.activity} | accessibility: {item.accessibility} | " +
                $"type: {item.type} | participants: {item.participants} | " +
                $"price: {item.price} | link: {item.link} | key: {item.key}{Environment.NewLine}";
            }

            return s;
        }
    }
}
