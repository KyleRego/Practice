const solution = require("./noRepeatSubstring");

test('test 1', () => {
    let s = "abcabcbb";

    expect(solution(s)).toBe(3);
})

test('test 2', () => {
    let s = "555das456h5f3";

    expect(solution(s)).toBe(7);
})