using Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;


// public class ApplicationDbContext: DbContext
public class ApplicationDbContext: IdentityDbContext<AppUser> {
    // base() - allows us to access the constructor of DbContext
    // ApplicationDbContext - allows us to access DB tables
    public ApplicationDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
    {
        
    }

    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Comment> Comments { get; set; } 

}