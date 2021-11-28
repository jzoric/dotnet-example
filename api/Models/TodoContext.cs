
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace todo.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todo { get; set; } = null!;
    }
}
