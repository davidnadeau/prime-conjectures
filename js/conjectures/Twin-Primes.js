var TwinPrime = (function() {
	var currentPair;

	function isTwinPrime(x, y) {
		return y - x == 2;
	}
		
	return {
		nextPair: function() {
			var p1, p2;
			do {
				p1 = Prime.currentPrime();
				p2 = Prime.nextPrime();
			} while (!isTwinPrime(p1,p2));
			
			currentPair = '('+p1.toString()+", "+p2.toString()+')';
			return currentPair;
		}
	}
}());
