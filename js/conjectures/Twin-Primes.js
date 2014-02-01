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