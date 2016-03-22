using iTELCO.BusinessInterfaces;
using iTELCO.Infrastructure.Log4NetProvider;
using iTELCO.Infrastructure.WebMatrixSecurity;
using log4net;
using Ninject.Modules;

namespace iTELCO.DependencyResolver.Web
{
    public class BusinessNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWebSecurityProvider>().To<WebMatrixWebSecurityProvider>();
            Bind<ISessionProvider>().To<HttpSessionSessionProvider>();

            Bind<ILogProvider>().To<Log4NetLogProvider>();
            Bind<ILog>().ToMethod(ctx => LogManager.GetLogger(typeof(BusinessNinjectModule)));

            Container.Initialize(Kernel);
        }

    }
}
