using Ninject.Modules;
using Ninject.Web.Common;
using Northwind.MusicStore.Data;
using Northwind.MusicStore.Data.Context;
using Northwind.MusicStore.RepositoryInterfaces;

namespace iTELCO.DependencyResolver.Web
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IDbContextFactory>().To<MusicStoreDbContextFactory>().InRequestScope();
            Bind<IUnitOfWork>().To<MusicStoreUnitOfWork>().InRequestScope();
            
            Bind<IAlbumsRepository>().To<AlbumRepository>().InRequestScope();
           
        }
        
    }
}