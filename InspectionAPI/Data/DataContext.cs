using Microsoft.EntityFrameworkCore;
using InspectionAPI;


namespace InspectionAPI.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<Status> Statuses{ get; set; }

        public DbSet<InspectionAPI.InspectionType>? InspectionType { get; set; }
    }
}
 