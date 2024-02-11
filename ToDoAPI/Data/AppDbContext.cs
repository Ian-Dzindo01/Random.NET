using Microsoft.EntityFrameworkCore;
using ToDoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Data
{   
    // Constructor
    public class AppDbContext : DbContext
    {    // Call constructor of base class pass options to it.
         public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }
        // Representation of to do items in sqlite database
        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}   