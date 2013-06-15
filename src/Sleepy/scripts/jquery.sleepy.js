(function ($) {
	if (!$) {
		alert("Please include jQuery before using sleepy.");
		return;
	}

	$.sleepy = function (timeinms, done) {
		if (!timeinms) {
			timeinms = 1000;
		}
		if (!done) {
			done = $.noop;
		}
		$.ajax({
			url: "http://sleepy.apphb.com/sleep/" + timeinms, // sleep for timeinms on the server
			async: false                                      // execute this request synchronously
		}).done(done);
	};
})(jQuery);