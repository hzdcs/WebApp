using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class TodoItemContext : DbContext
    {
        public TodoItemContext (DbContextOptions<TodoItemContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
