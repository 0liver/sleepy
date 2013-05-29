using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Sleepy.App_Start;

namespace Sleepy {
	public class MvcApplication : HttpApplication {
		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
		}
	}
}