using iTELCO.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace iTELCO.Data.Context
{
    public class iTELCODbContext : DbContext
    {
        public IDbSet<User> Users { get; set; }
      

        public iTELCODbContext()
            : base("DefaultConnection")
        {
        }

        public iTELCODbContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //modelBuilder.Entity<Album>().ToTable("Albums");
            //modelBuilder.Configurations.Add(new AlbumConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}