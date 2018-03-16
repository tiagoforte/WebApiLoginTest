using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiWebbsys.Data
{
  public class DataContext : DbContext
  {

    public DataContext(DbContextOptions<DataContext> option) : base(option)
    {
           
    }

    public DbSet<Entity.Usuario> Usuario { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Entity.Usuario>().ToTable("Usuario");
    }

    

  }
}
