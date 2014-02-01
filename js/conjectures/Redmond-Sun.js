var RedmondSun = (function() {
	
	function primeInRange(x,y,m,n) {
		var l = [];
		var start = Math.pow(x,m);
		var end = Math.pow(y,n);
		if (start < end) {
			for (var i = start; i <= end; i++) {
				if (Prime.isPrime(i)) return true;		
			}
			return false;
		} else {
			//only positive ranges are significant in this conjecture
			return true;
		}
	}

	return {
		getExceptions: function(limit) {
			var excep = [];
			var x, y, m, n;
			for (x = 2; x <= limit; x++)
			for (y = 2; y <= limit; y++)
			for (m = 2; m <= limit; m++)
			for (n = 2; n <= limit; n++) {
				if (!primeInRange(x,y,m,n)) {
					var range = '['+x.toString() +'^'+m.toString() +", "+y.toString()+'^'+n.toString() +']';
					excep.push(range);
				}
			}
			return excep;
		}
	};
}());
