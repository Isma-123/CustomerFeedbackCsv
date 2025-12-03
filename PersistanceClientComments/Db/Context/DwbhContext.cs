
using Damain.ClientComments.cs.Api;
using Damain.ClientComments.cs.Dwbh.Dimensions;
using Microsoft.EntityFrameworkCore;

namespace PersistanceClientComments.Db.Context
{
    public partial class DwbhContext : DbContext
    { 
        public DwbhContext(DbContextOptions<DwbhContext> options) : base(options) { }


        #region 
        public DbSet<DimTiempo> DimTiempos { get; set; }    
        public DbSet<DimFuente> DimFuentes { get; set; }
        public DbSet<DimWebReviuw> DimWebReviuws { get; set; } 
        public DbSet<DimClientes> DimClientes { get; set; } 
        public DbSet<DimProducto> DimProductos { get; set; }    
        public DbSet<DimSocialComment> DimSocialComments { get; set; }  
        public DbSet<DimSurvey> DimSurveys { get; set; }
        #endregion


    }
}
