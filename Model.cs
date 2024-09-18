using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BattleAxe;
public class UnitContext : DbContext
{
    public DbSet<Unit> Units {  get; set; }

    // The following configures EF to use SQL server localdb
    // localdb must be installed first
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options
        .UseSqlServer(@"Data Source=DESKTOP-1D9LOKK;Initial Catalog=BattleAxe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;")
        .LogTo(Console.WriteLine, LogLevel.Information); //Logs SQL queries to console
}

public class Unit
{
    public string? UnitName { get; set; }
    public int UnitCost {  get; set; }
    public string? UnitType { get; set; }
    public int UnitId { get; set; }
}
