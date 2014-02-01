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
