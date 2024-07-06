const collectKeys = require('./syntaxPractice');

test('test 1', () => {
    let obj =
    {
        hello: "world",
        second: "key"
    };

    let result = collectKeys(obj, "cat")

    expect(result.length).toBe(2);

    let expectedResult = ["cathello", "catsecond"];

    for (let i = 0; i < expectedResult.length; i += 1)
    {
        expect(result[i]).toBe(expectedResult[i]);
    }
})