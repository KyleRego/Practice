namespace Challenges;

public class CountNumberOfTeams
{
    // this gets time limit exceeded, which is what I expected
    public static int Soln(int[] ratings)
    {
        List<List<int>> validTeams = [];
        List<List<int>> formingTeams = [];

        for (int i = 0; i < ratings.Length; i += 1)
        {
            int rating = ratings[i];

            List<List<int>> newFormingTeams = [];

            foreach (List<int> formingTeam in formingTeams)
            {
                if (AscendingTeam(formingTeam) && rating > formingTeam.Last())
                {
                    List<int> newTeam = MakeNewTeam(formingTeam, rating);

                    if (newTeam.Count == 3)
                    {
                        validTeams.Add(newTeam);
                    }
                    else
                    {
                        newFormingTeams.Add(newTeam);
                    }
                }
                else if (DescendingTeam(formingTeam) && rating < formingTeam.Last())
                {
                    List<int> newTeam = MakeNewTeam(formingTeam, rating);

                    if (newTeam.Count == 3)
                    {
                        validTeams.Add(newTeam);
                    }
                    else
                    {
                        newFormingTeams.Add(newTeam);
                    }
                }
            }

            foreach (List<int> nt in newFormingTeams)
            {
                formingTeams.Add(nt);
            }

            List<int> newFormingTeam = new([rating]);
            formingTeams.Add(newFormingTeam);
        }

        return validTeams.Count;
    }

    private static bool AscendingTeam(List<int> team)
    {
        for (int i = 0; i < team.Count - 1; i += 1)
        {
            if (team[i + 1] < team[i])
            {
                return false;
            }
        }

        return true;
    }

    private static bool DescendingTeam(List<int> team)
    {
        for (int i = 0; i < team.Count - 1; i += 1)
        {
            if (team[i + 1] > team[i])
            {
                return false;
            }
        }

        return true;
    }

    private static List<int> MakeNewTeam(List<int> team, int rating)
    {
        int[] array = new int[team.Count + 1];
        team.CopyTo(array);
        array[^1] = rating;

        return [.. array];
    }
}