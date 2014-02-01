var Prime = (function() {
	var currentPrime = 2,
		primeCount = 2;
		
	return {
		//primality test from wikipedia
		// https://en.wikipedia.org/wiki/Primality_test#Python_implementation
		isPrime: function(n) {
			if (n < 2) return false;
			if (n === 2 || n === 3) return true;
			if (n % 2 === 0 || n % 3 === 0) return false;
			var largestDivisor = Math.round(Math.sqrt(n));
			for (var i = 5; i <= largestDivisor; i+=6) {
				if (n % i === 0 || n % (i + 2) === 0) return false;
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
	};

}());
