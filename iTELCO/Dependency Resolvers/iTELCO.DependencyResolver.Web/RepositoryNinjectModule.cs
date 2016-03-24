using Ninject.Modules;
using Ninject.Web.Common;
using iTELCO.Data;
using iTELCO.Data.Context;
using iTELCO.RepositoryInterfaces;

namespace iTELCO.DependencyResolver.Web
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IDbContextFactory>().To<iTELCODbContextFactory>().InRequestScope();
            Bind<IUnitOfWork>().To<iTELCOUnitOfWork>().InRequestScope();
            
           // Bind<IAlbumsRepository>().To<AlbumRepository>().InRequestScope();
           
        }
        
    }
}