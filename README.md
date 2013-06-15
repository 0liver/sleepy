sleepy
======

A solution to using **Thread.Sleep()** inside JavaScript.

Usage
-----
```javascript
// do something here

$.ajax({
  url:   "http://sleepy.apphb.com/sleep/1000", // sleep for 1000ms on the server
  async: false                                 // execute this request synchronously
});

// continue doing something here
```

Or include `jquery.sleepy.js` and simply call `$.sleep(1000);`:
```html
<script src="http://sleepy.apphb.com/scripts/jquery.sleepy.js"></script>
```

```javascript
// do something here

$.sleep(1000);

// continue doing something here
```

More ways to use sleepy
-----------------------
```javascript
// sleep for the default amount of time, i.e. 1000ms
$.sleep();
```
```javascript
// call the provided callback function when done sleeping
$.sleep(2000, function () {
  alert("Done sleeping.");
});
```
```javascript
// call the provided callback function with the server response data
// currently there's one property, slept, which contains the time slept
$.sleep(2000, function (data) {
  alert("Slept for " + data.slept + "ms.");
});
```
