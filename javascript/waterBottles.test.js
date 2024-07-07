const waterBottles = require('./waterBottles.js');

test('test 1', () => {
    let result = waterBottles(15, 4);
    expect(result).toBe(19);
})