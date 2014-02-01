var Prime = (function() {
	var 	currentPrime = 2,
		primeCount = 2;
		
	return {
		isPrime: function(n) {
			if (n < 2) return false;
			for (var i = 2; i < n; i++) {
				if (n % i === 0 && i !== n) return false;
			}
			return true;
		},
		currentPrime: function() {
			return currentPrime;
		},
		nextPrime: function() {
			primeCount++;
			while (!Prime.isPrime(primeCount)) primeCount++;
			currentPrime = primeCount;
			return currentPrime;
		}
	}

}());

var TwinPrime = (function() {
	var currentTwin;

	function isTwin(x, y) {
		return y - x == 2;
	}
		
	return {
		currentTwin: function() {
			return currentTwin;
		},
		nextTwin: function() {
			var p1, p2;
			do {
				p1 = Prime.currentPrime();
				p2 = Prime.nextPrime();
			} while (!isTwin(p1,p2));
			
			currentTwin = '('+p1.toString()+", "+p2.toString()+')';
			return currentTwin;
		}
	}
}());

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

var PrimeConjectures = (function() {
	
	
	return {
		twinPrimeConjecture: (function() {
			var twins = [];

			function getTwin(n) {
				var i = twins.length;
				while (i++ < n) twins.push( TwinPrime.nextTwin() );
				return twins.slice(-1)[0];
			}	
			return {
				test: function() {
					console.log("10th Prime Twin:   ", getTwin(10));
					console.log("50th Prime Twin:   ", getTwin(50));
					console.log("100th Prime Twin:  ", getTwin(100));
					console.log("500th Prime Twin:  ", getTwin(500));
					console.log("1000th Prime Twin: ", getTwin(1000));
				}
			};
		}()),
		
		redmondSunConjecture: (function() {
			return {
				test: function() {
					console.log("Redmond-Sun Test, Expect 2 terms: ", RedmondSun.getExceptions(5));
					console.log("Redmond-Sun Test, Expect 3 terms: ", RedmondSun.getExceptions(6));
				}
			}	
		}())
	};
}());

PrimeConjectures.twinPrimeConjecture.test();
PrimeConjectures.redmondSunConjecture.test();

