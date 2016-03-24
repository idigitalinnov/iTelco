using System;
using iTELCO.Data.Context;
using iTELCO.RepositoryInterfaces;

namespace iTELCO.Data
{
    public class iTELCOUnitOfWork : IUnitOfWork
    {
        private IDbContextFactory _contextFactory;
        private iTELCODbContext _context;

        public iTELCOUnitOfWork(IDbContextFactory contextFactory)
        {
            if (contextFactory == null)
            {
                throw new ArgumentNullException("contextFactory");
            }

            _contextFactory = contextFactory;
        }

        protected iTELCODbContext Context
        {
            get { return _context ?? (_context = _contextFactory.Get()); }
        }

        public void SaveChanges()
        {
            Context.Commit();
        }
    }
}
