function twoSum(nums, target) {
    let map = new Map();

    for (let i = 0; i < nums.length; i += 1)
    {
        let currNum = nums[i];

        let complement = target - currNum;

        if (map.has(complement))
        {
            return [i, map.get(complement)];
        }
        else
        {
            map.set(currNum, i);
        }
    }

    return null;
};

module.exports = twoSum;