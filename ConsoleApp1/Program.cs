using System;

namespace Program360
{
    public class Soccer
    {
        /**
         * RECEIVE: array of match strings in the form: 
         *      "<TeamA-name>#<TeamA-goals>@<TeamB-goals>#<TeamB-name>"
         *      
         * RETURN: array of rank strings in the form: 
         *      "<final-rank>) <Team-name> <points>p, <games-played>g (<W>-<T>-<L>), <goal-differential>gd (<goals-scored>-<goals-against>)"
         */
        public static string[] getRankings(string[] matches)
        {
            // The rankings array stores the group name first, then
            // the teams ranked 1-4.
            string[] rankings = new string[5];
            rankings[0] = matches[0];

            // Store team names in strings. Get team names from first two matches.
            char[] delimiters = { '#', '@' };
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

            // Loop through the matches and add to each team's stats.
            for (int i=1; i<matches.Length; i++)
            {
                string[] matchArray = matches[i].Split(delimiters);
                string awayTeam = matchArray[0];
                string homeTeam = matchArray[3];
                // Check for twelve matchups:
                // A @ B, A @ C, A @ D, B @ A, B @ C, B A D,
                // C @ A, C @ B, C @ D, D @ A, D @ B, D @ C
                if ( awayTeam.Equals(teamA) && homeTeam.Equals(teamB) )
                {
                    UpdateStats(matchArray, statsA, statsB);   
                }
                else if ( awayTeam.Equals(teamA) && homeTeam.Equals(teamC) )
                {
                    UpdateStats(matchArray, statsA, statsC);
                }
                else if ( awayTeam.Equals(teamA) && homeTeam.Equals(teamD) )
                {
                    UpdateStats(matchArray, statsA, statsD);
                }
                else if ( awayTeam.Equals(teamB) && homeTeam.Equals(teamA) )
                {
                    UpdateStats(matchArray, statsB, statsA);
                }
                else if ( awayTeam.Equals(teamB) && homeTeam.Equals(teamC) )
                {
                    UpdateStats(matchArray, statsB, statsC);
                }
                else if ( awayTeam.Equals(teamB) && homeTeam.Equals(teamD) )
                {
                    UpdateStats(matchArray, statsB, statsD);
                }
                else if ( awayTeam.Equals(teamC) && homeTeam.Equals(teamA) )
                {
                    UpdateStats(matchArray, statsC, statsA);
                }
                else if ( awayTeam.Equals(teamC) && homeTeam.Equals(teamB))
                {
                    UpdateStats(matchArray, statsC, statsB);
                }
                else if (awayTeam.Equals(teamC) && homeTeam.Equals(teamD) )
                {
                    UpdateStats(matchArray, statsC, statsD);
                }
                else if ( awayTeam.Equals(teamD) && homeTeam.Equals(teamA) )
                {
                    UpdateStats(matchArray, statsD, statsA);
                }
                else if ( awayTeam.Equals(teamD) && homeTeam.Equals(teamB) )
                {
                    UpdateStats(matchArray, statsD, statsB);
                }
                else if ( awayTeam.Equals(teamD) && homeTeam.Equals(teamC) )
                {
                    UpdateStats(matchArray, statsD, statsC);
                }
            }

            Console.Write(teamA + ": ");
            for (int i=0; i<statsA.Length; i++)
            {
                Console.Write(statsA[i] + ",");
            }
            Console.WriteLine();
            Console.Write(teamB + ": ");
            for (int i = 0; i < statsB.Length; i++)
            {
                Console.Write(statsB[i] + ",");
            }
            Console.WriteLine();
            Console.Write(teamC + ": ");
            for (int i = 0; i < statsC.Length; i++)
            {
                Console.Write(statsC[i] + ",");
            }
            Console.WriteLine();
            Console.Write(teamD + ": ");
            for (int i = 0; i < statsD.Length; i++)
            {
                Console.Write(statsD[i] + ",");
            }

            // unordered array of all the teams' stats
            int[][] allStats = { statsA, statsB, statsC, statsD };

            return rankings;
        }

        /**
         * Read in a match string, and update the stats of the two teams playing in the match.
         * 
         * Match array has the form:   {"awayTeam", "awayTeamGoals", "homeTeamGoals", "homeTeam"}
         *                              0           1                2                3
         * 
         * Stats arrays have the form:  {pts, games played, W, T, L, goal differential, goals scored, goals against}
         *                               0    1             2  3  4  5                  6             7
         */
        static void UpdateStats(string[] matchArray, int[] awayTeamStats, int[] homeTeamStats)
        {
            // increment games played
            awayTeamStats[1] += 1;
            homeTeamStats[1] += 1;

            // update goal differential, goals scored, goals against
            int awayGoals = Int32.Parse(matchArray[1]);
            int homeGoals = Int32.Parse(matchArray[2]);
            awayTeamStats[5] += awayGoals - homeGoals;
            homeTeamStats[5] += homeGoals - awayGoals;
            awayTeamStats[6] += awayGoals;
            homeTeamStats[6] += homeGoals;
            awayTeamStats[7] += homeGoals;
            homeTeamStats[7] += awayGoals;

            // TIE: +1 pts, +1 tie for both teams
            if (awayGoals == homeGoals)
            {
                awayTeamStats[0] += 1;
                homeTeamStats[0] += 1;
                awayTeamStats[3] += 1;
                homeTeamStats[3] += 1;
            }
            // AWAY TEAM WINS: +3 pts, +1 win for away team; +1 loss for home team
            else if (awayGoals > homeGoals)
            {
                awayTeamStats[0] += 3;
                awayTeamStats[2] += 1;
                homeTeamStats[4] += 1;
            }
            // HOME TEAM WINS: +3 pts, +1 win for home team; +1 loss for away team
            else
            {
                homeTeamStats[0] += 3;
                homeTeamStats[2] += 1;
                awayTeamStats[4] += 1;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
