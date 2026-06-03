using Microsoft.EntityFrameworkCore;

namespace dahub.infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
