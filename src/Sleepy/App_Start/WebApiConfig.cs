using System.Web.Http;

namespace Sleepy.App_Start {
	public static class WebApiConfig {
		public static void Register(HttpConfiguration config) {
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "{controller}/{id}",
				defaults: new { controller = "sleep", id = RouteParameter.Optional }
				);
		}
	}
}