using FInancingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FInancingManager
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CostEntity> Costs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=PD324_Team2.mssql.somee.com;packet size=4096;user id=sweetdie_SQLLogin_1;pwd=rsxbyswded;data source=PD324_Team2.mssql.somee.com;persist security info=False;initial catalog=PD324_Team2;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
