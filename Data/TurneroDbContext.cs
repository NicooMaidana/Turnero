using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Turnero.Models;

namespace Turnero.Data;

public class TurneroDbContext : IdentityDbContext
{
    public TurneroDbContext(DbContextOptions<TurneroDbContext> options)
        : base(options)
    {
    }

    public DbSet<Provincia> Provincias { get; set; }
    public DbSet<Localidad> Localidades { get; set; }
}
