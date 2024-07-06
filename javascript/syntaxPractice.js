function collectKeys(obj, prefix)
{
    // I did not know how to get the keys of a JS object
    // in an online skills test I took recently
    let keys = Object.keys(obj);
    let result = [];

    for (let i = 0; i < keys.length; i += 1)
    {
        result.push(`${prefix}${keys[i]}`);
    }

    return result;
}
module.exports = collectKeys;