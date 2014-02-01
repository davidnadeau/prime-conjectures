var RedmondSun = (function() {
	function containsPrime(l) {
		if (l.length === 0) return true;
		for (var i = 0; i < l.length; i++) if (Prime.isPrime(l[i])) return true;
		return false;
	}
	function generateRange(x,y,m,n) {
		var l = [];
		var start = Math.pow(x,m);
		var end = Math.pow(y,n);
		if (start !== end) for (var i = start; i <= end; i++) l.push(i);
		return l;
	}

	return {
		getExceptions: function(limit) {
			var excep = [];
			var x, y, m, n;
			for (x = 2; x <= limit; x++)
			for (y = 2; y <= limit; y++)
			for (m = 2; m <= limit; m++)
			for (n = 2; n <= limit; n++) {
				if (!containsPrime(generateRange(x,y,m,n))) {
					var range = '['+x.toString() +'^'+m.toString() +", "+y.toString()+'^'+n.toString() +']';
					excep.push(range);
				}
			}
			return excep;
		}
	}
}());
