using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace app.Models
{
    public class TodoContext : DbContext
    {
       public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
       {
       }
        public DbSet<UserItem> UserItems { get; set; } = null!;
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        
    }
}
