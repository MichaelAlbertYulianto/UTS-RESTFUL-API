using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
    }

    public DbSet<Users> Users {get; set;}
    public DbSet<Posts>Posts{get; set;}
    public DbSet<Students>Students{get; set;}
    public DbSet<Courses>Courses{get; set;}

}