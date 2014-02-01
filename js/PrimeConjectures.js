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

function testConjectures() {
	PrimeConjectures.twinPrimeConjecture.test();
	PrimeConjectures.redmondSunConjecture.test();
}

testConjectures();

