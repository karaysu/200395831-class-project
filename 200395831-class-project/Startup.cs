using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200395831_class_project.Startup))]
namespace _200395831_class_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
