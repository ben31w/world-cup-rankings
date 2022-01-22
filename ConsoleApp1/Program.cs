using System;

namespace Program360
{
    public class Soccer
    {
        public static string[] getRankings(string[] matches)
        {
            // The rankings array stores the group name first, then
            // the teams ranked 1-4.
            string[] rankings = new string[5];
            rankings[0] = matches[0];

            // GET:     "<TeamA-name>#<TeamA-goals>@<TeamB-goals>#<TeamB-name>"
            // RETURN:  "<a>) <Team-name> <b>p, <c>g (<d>-<e>-<f>), <g>gd (<h>-<i>)"

            char[] delimiters = { '#', '@' }; // the characters delimiting the matches

            /*            // Store four teams in a dictionary.
                        // Key = team name
                        // Value = int[]{pts, games played, W, T, L, goal differential, goals scored, goals against}
                        Dictionary<string, int[]> teams = new Dictionary<string, int[]>();

                        // Get the team names by examining the first two matches.
                        string[] match1 = matches[1].Split(delimiters);
                        string[] match2 = matches[2].Split(delimiters);
                        teams.Add(match1[0], new int[8]); // team 1
                        teams.Add(match1[3], new int[8]); // team 2
                        teams.Add(match2[0], new int[8]); // team 3
                        teams.Add(match2[3], new int[8]); // team 4*/


            // Store team names in strings. Get team names from first two matches
            string[] match1 = matches[1].Split(delimiters);
            string[] match2 = matches[2].Split(delimiters);
            string teamA = match1[0];
            string teamB = match1[3];
            string teamC = match2[0];
            string teamD = match2[3];

            // Store each team's stats in an array of integers.
            // {pts, games played, W, T, L, goal differential, goals scored, goals against}
            //  0    1             2  3  4  5                  6             7
            int[] statsA = new int[8];
            int[] statsB = new int[8];
            int[] statsC = new int[8];
            int[] statsD = new int[8];

            // Loop through the matches and add to each team's data.
            foreach (string match in matches)
            {
                // GET:     "<TeamA-name>#<TeamA-goals>@<TeamB-goals>#<TeamB-name>"
                string[] temp = match.Split(delimiters);
                if ( temp[0].Equals(teamA) && temp[3].Equals(teamB) )
                {
                    // add to games played, goal differential, goals scored, goals against
                    int goalsScoredA = Int32.Parse(temp[1]);
                    int goalsScoredB = Int32.Parse(temp[2]);

                    statsA[1] += 1;
                    statsB[1] += 1;
                    statsA[5] += goalsScoredA - goalsScoredB;
                    statsB[5] += goalsScoredB - goalsScoredA;
                    statsA[6] += goalsScoredA;
                    statsB[6] += goalsScoredB;
                    statsA[7] += goalsScoredB;
                    statsB[7] += goalsScoredA;

                    // TIE
                    if (goalsScoredA == goalsScoredB)
                    {
                        statsA[0] += 1;
                        statsB[0] += 1;
                        statsA[3] += 1;
                        statsB[3] += 1;
                    }
                    // Team A wins
                    else if (goalsScoredA > goalsScoredB)
                    {
                        statsA[0] += 3;
                        statsA[2] += 1;
                        statsB[4] += 1;
                    }
                    // Team B wins
                    else
                    {
                        statsB[0] += 3;
                        statsB[2] += 1;
                        statsA[4] += 1;
                    }
                }
            }



            return rankings;
        }
        static void Main(string[] args)
        {
        }
    }
}
