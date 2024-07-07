// this is pretty much equivalent to the "two pointers" approach
function reverseString(chars)
{
    for (let i = 0; i < Math.floor(chars.length / 2); i += 1)
    {
        let heldChar = chars[i];
        chars[i] = chars[chars.length - 1 - i];
        chars[chars.length - 1 - i] = heldChar;
    }

    return chars;
}
module.exports = reverseString;