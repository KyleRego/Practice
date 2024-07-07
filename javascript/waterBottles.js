function waterBottles(numBottles, numExchange)
{
    let drank = 0;

    while (numBottles >= numExchange)
    {
        // Need to use Math.floor to make it true integer division;
        // otherwise this returns a floating point value
        let numExchanges = Math.floor(numBottles / numExchange);
        drank += numExchanges * numExchange;
        numBottles = numBottles % numExchange;
        numBottles += numExchanges
    }

    return drank + numBottles;
}

module.exports = waterBottles;