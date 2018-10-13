using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SearchSortPaging.Startup))]
namespace SearchSortPaging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
