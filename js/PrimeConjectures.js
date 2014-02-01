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
					//generate increasing large twin primes
					for (var i = 10; i <= 1250; i*=5) {
						console.log(" Twin Prime Test: ", getTwin(i));
					}
				}
			};
		}()),
		
		redmondSunConjecture: (function() {
			return {
				test: function() {
					//// test the first 5 ranges
					// i {0,1,2} have no exceptional intervals
					for (var i = 3; i < 8; i++) {
						console.log("Redmond-Sun Test ", RedmondSun.getExceptions(i));
					}
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

