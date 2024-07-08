const last = require('./arrayPrototypeLast');

test('test 1', () => {
    Array.prototype.last = last;

    let arr = [1, 2, 3];

    expect(arr.last()).toBe(3);
});