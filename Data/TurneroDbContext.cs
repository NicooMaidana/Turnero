using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Turnero.Data;

public class TurneroDbContext : IdentityDbContext
{
    public TurneroDbContext(DbContextOptions<TurneroDbContext> options)
        : base(options)
    {
    }
}
