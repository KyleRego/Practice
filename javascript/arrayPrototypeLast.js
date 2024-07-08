// this problem is really a test of being able to
// add a method to the prototype of a built in type (Array)
function last()
{
    if (this.length == 0)
    {
        return -1;
    }
    else
    {
        return this[this.length - 1];
    }
}
// one thing about this problem, which asks to add a method
// to the Array prototype, is that I am exporting the method
// and then adding it to Array.prototype in the test
// instead of doing that here
module.exports = last;
