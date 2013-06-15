using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web.Http;
using Newtonsoft.Json;

namespace Sleepy.Controllers {
	public class SleepController : ApiController {
		// GET sleep/5
		public object Get(int id) {
			var millisecondsTimeout = id;
			Thread.Sleep(millisecondsTimeout);
			var json = JsonConvert.SerializeObject(new { slept = millisecondsTimeout });
			return new HttpResponseMessage
			       	{
			       		Content = new StringContent(json, Encoding.UTF8, "application/json")
			       	};
		}
	}
}