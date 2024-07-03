const twoSum = require('./2sum');

test('test 1', () => {
    let nums = [2,7,11,15];
    let target = 9;

    let result = twoSum(nums, target);

    expect(result.length).toBe(2);
    expect(result.includes(0)).toBe(true);
    expect(result.includes(1)).toBe(true);
});