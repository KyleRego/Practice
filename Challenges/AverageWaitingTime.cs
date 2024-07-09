namespace Challenges;

public class AverageWaitingTime
{
    public static double Soln(int[][] customers)
    {
        int startingTime = customers[0][0];
        List<double> waitingTimes = [];

        foreach (int[] customer in customers)
        {
            int arrivalTime = customer[0];
            int prepareFoodTime = customer[1];

            if (arrivalTime > startingTime)
            {
                startingTime = arrivalTime;
            }

            int waitTime = startingTime + prepareFoodTime - arrivalTime;
            waitingTimes.Add(waitTime);
            startingTime += prepareFoodTime; 
        }

        double result = 0;

        foreach (double time in waitingTimes)
        {
            result += time;
        }

        result /= waitingTimes.Count;

        return result;    
    }
}