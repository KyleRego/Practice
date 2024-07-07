const reverseString = require('./reverseString');

test('test 1', () => {
    let result = reverseString(["a", "b", "c"]);
    let expected = ["c", "b", "a"];

    for (let i = 0; i < expected.length; i += 1)
    {
        expect(result[i]).toBe(expected[i]);
    }
});