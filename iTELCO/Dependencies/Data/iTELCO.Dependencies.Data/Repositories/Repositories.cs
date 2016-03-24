using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTELCO.Data.Context;
using iTELCO.RepositoryInterfaces;
using iTELCO.Domain;

namespace iTELCO.Data
{


    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(IDbContextFactory contextFactory) : base(contextFactory) { }

        
    }
    
   }
