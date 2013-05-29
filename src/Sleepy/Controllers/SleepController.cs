using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web.Http;

namespace Sleepy.Controllers {
	public class SleepController : ApiController {
		// GET sleep
		public object Get() {
			var html =
				@"
<h1>A simple Thread.Sleep() wrapper to use from your JavaScript code</h1>
<p>Assuming the use of jQuery, call like this:</p>
<pre><code>
// do something here

$.ajax({
  url: /sleep/1000, // sleep for 1000ms on the server
  async: false      // execute this request synchronously
})

// continue doing something here
</code></pre>

<h3>Try out now</h3>
<input value='1000' />
<button>Click to wait</button>
<p>Here is the log:</p>
<ul id=""log""></ul>
<script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
<script>
	$(function(){
		function pad(n) { return n < 10 ? '0' + n : n; }

		function log(msg) {
			var d = new Date();
			date = pad(d.getHours()) + ':'
				  + pad(d.getMinutes()) + ':'
				  + pad(d.getSeconds()) + '.'
				  + pad(d.getMilliseconds());
			$('#log').append('<li>' + date + ' - ' + (msg ? msg : ''));
		}

		$('button').on('click', function(ev) {
			ev.preventDefault();
			log('start of click handler');
			$.ajax({
				url: '/sleep/' + $('input').val(),
				async: false
			}).done(function(data){
				log('returned from server with: ' + JSON.stringify(data));
			});
			log('end of click handler');
			log('~~~~~~~~~~~~~~~~~~~~~~~~~~~~');
		});
	})
</script>
";
			return new HttpResponseMessage
			       	{
			       		Content = new StringContent(html, Encoding.UTF8, "text/html")
			       	};
		}

		// GET sleep/5
		public object Get(int id) {
			var millisecondsTimeout = id;
			Thread.Sleep(millisecondsTimeout);
			return new { slept = millisecondsTimeout };
		}
	}
}