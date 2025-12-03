using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReadClientsComments.cs.Models.Entities;

namespace ReadClientsComments.cs.Models.Context
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions options) : base(options)
        {
        }

       

        #region  
        public DbSet<ViuwClient> clientes { get; set; } 
        public DbSet<ViuwProducts> products { get; set; }
        public DbSet<ViuwSocialComments> socialComments { get; set; }   

        #endregion
    }
}
