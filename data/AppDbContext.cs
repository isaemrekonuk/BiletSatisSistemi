using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    
    public DbSet<Musteri> Musteris { get; set; }
    public DbSet<Adres> Adress { get; set; }
    public DbSet<Ilce> Ilces { get; set; }
    public DbSet<IletisimForm> IletisimForms { get; set; }
    public DbSet<Sehir> Sehirs { get; set; }
    public DbSet<Ulke> Ulkes { get; set; }
}