using System.Web;

namespace CompatibleSoftware.ContactManager.UI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Infrastructure.Bootstrapper.Run();
        }
    }
}