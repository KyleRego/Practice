// Given a string s, find the length of the longest 
// substring without repeating characters.

function solution(s)
{
    if (s.length <= 1) return s.length;

    let leftIndex = 0;
    let rightIndex = 0;

    let longestStreak = 0;
    let currentStreak = 0;

    let map = new Map();

    while (rightIndex < s.length)
    {
        let rightChar = s[rightIndex];
        
        if (!map.has(rightChar))
        {
            map.set(rightChar, 1);
            rightIndex += 1;
            currentStreak += 1;
            longestStreak = (currentStreak > longestStreak) ? currentStreak : longestStreak;
        }
        else
        {
            let rightCharAmt = map.get(rightChar);

            if (rightCharAmt == 0)
            {
                map.set(rightChar, 1);
                rightIndex += 1;
                currentStreak += 1;
                longestStreak = (currentStreak > longestStreak) ? currentStreak : longestStreak;
            }
            else if (rightCharAmt == 1)
            {
                map.set(rightChar, 2);

                while (map.get(rightChar) == 2)
                {
                    if (leftIndex >= s.length) return longestStreak;

                    let leftChar = s[leftIndex];

                    let leftCount = map.get(leftChar);

                    map.set(leftChar, leftCount - 1);

                    leftIndex += 1;
                    currentStreak -= 1;
                }

                rightIndex += 1;
                currentStreak += 1;
                longestStreak = (currentStreak > longestStreak) ? currentStreak : longestStreak;
            }
            else
            {
                throw "something went wrong";
            }
        }
    }

    return longestStreak; 
    
}

module.exports = solution;