using System.Web.Mvc;

namespace CompatibleSoftware.Infrastructure.Startup
{
    public class RegisterAreas : IBootstrapperTask
    {
        public RegisterAreas()
        {
        }

        public void Execute()
        {
            AreaRegistration.RegisterAllAreas();
        }
    }
}
