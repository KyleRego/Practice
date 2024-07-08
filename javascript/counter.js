// this is about scope/closures in JS
// no accompanying unit tests for this right now
var createCounter = function(n) {
    let timesCalled = 0;

    return function() {
        if (timesCalled == 0)
        {
            timesCalled += 1;
            return n;
        }
        else
        {
            timesCalled += 1;
            return n + timesCalled;
        }
    };
};