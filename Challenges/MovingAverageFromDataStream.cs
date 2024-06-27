namespace Challenges;

public class MovingAverage(int size)
{
    private readonly int _size = size;
    private readonly List<int> _vals = [];

    public double Next(int val)
    {
        _vals.Add(val);

        double sum = 0;
        int tracker = 0;

        // A better way for the iteration: something like
        // iterate from a starting i that is the max of 0 or the length minus _size
        for (int i = _vals.Count - 1; i >= 0 && tracker < _size; i -= 1)
        {
            sum += _vals[i];
            tracker += 1;
        }

        if (_vals.Count < _size)
        {
            return sum / _vals.Count;
        }
        else
        {
            return sum / _size;
        }
    }
}