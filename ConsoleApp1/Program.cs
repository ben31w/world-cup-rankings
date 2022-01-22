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

            // Store four teams in a dictionary.
            // Key = team name
            // Value = {pts, games played, W, T, L, goal differential, goals scored, goals against}
            Dictionary<string, int[]> teams = new Dictionary<string, int[]>();

            // Get the team names by examining the first two matches.
            string[] match1 = matches[1].Split(delimiters);
            string[] match2 = matches[2].Split(delimiters);
            teams.Add(match1[0], new int[8]); // team 1
            teams.Add(match1[3], new int[8]); // team 2
            teams.Add(match2[0], new int[8]); // team 3
            teams.Add(match2[3], new int[8]); // team 4

            

            return rankings;
        }
        static void Main(string[] args)
        {
        }
    }
}
