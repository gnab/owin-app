using Owin;
using OwinApp.Middleware;

namespace OwinApp
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
            app.Use(typeof(Logger));
            app.Use(typeof(StaticFiles), "Content");
		}
	}
}
