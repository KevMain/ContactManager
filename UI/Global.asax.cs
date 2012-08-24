using System.Web.Mvc;
using Castle.Windsor;
using System.Web;
using Castle.Windsor.Installer;
using CompatibleSoftware.ContactManager.UI.Plumbing;

namespace CompatibleSoftware.ContactManager.UI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            BootstrapContainer();

            Infrastructure.Startup.Bootstrapper.Run();
        }

        protected void Application_End()
        {
            container.Dispose();
        }

        private static IWindsorContainer container;

        private static void BootstrapContainer()
        {
            container = new WindsorContainer().Install(FromAssembly.This());

            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}