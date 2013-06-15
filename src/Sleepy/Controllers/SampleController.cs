using System;
using System.IO;
using System.Reflection;
using System.Web.Mvc;

namespace Sleepy.Controllers {
	public class SampleController : Controller {
		//
		// GET: /Sample/

		public ActionResult Index() {
			return View();
		}

		public ActionResult Readme() {
			var assembly = Assembly.GetExecutingAssembly();
			var viewName = "Sleepy.README.md";
			using (var stream = assembly.GetManifestResourceStream(viewName)) {
				if (stream == null) throw new ArgumentNullException("resource stream for README.md");
				string readme=null;
				using (var streamReader = new StreamReader(stream)) {
					readme = streamReader.ReadToEnd();
				}
				return Content(readme);
			}
		}
	}
}