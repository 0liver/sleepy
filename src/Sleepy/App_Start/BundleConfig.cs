using System.Web.Optimization;

namespace Sleepy.App_Start {
	public class BundleConfig {
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles) {
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/pagedown").Include(
				"~/Scripts/pagedown.js"));
		}
	}
}