using iTELCO.Data.EntityConfig;
using System;

namespace iTELCO.Data.Context
{    public class iTELCODbContextFactory : IDbContextFactory
    {
        private iTELCODbContext _context;

        public iTELCODbContext Get()
        {
            if (_context == null) { InitialiseContext(); };

            return _context;
        }

        private void InitialiseContext()
        {
            //When Using SQLDeploy, we want to update the database ourselves.
            //System.Data.Entity.Database.SetInitializer<iTELCODbContext>(null);

            //To Use CodeFirst and have it create the sample data ..  this initialiser will create the database and insert sample data.
          //  System.Data.Entity.Database.SetInitializer<iTELCODbContext>(new iTELCODbInitializer());
            //once up and running, use the following
            //System.Data.Entity.Database.SetInitializer<iTELCODbContext>(null);

            //this is a sample of an alternative method
            //System.Data.Entity.Database.SetInitializer<MusicStoreEntities>(new CreateDatabaseIfNotExists<MusicStoreEntities>());

            _context = new iTELCODbContext();
        }
    }
}
