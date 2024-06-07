using Microsoft.EntityFrameworkCore;

namespace ChainOfRespProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-17Q1DFV\\SQLEXPRESS;initial Catalog = DbChainOfResponsibility; integrated security = true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
