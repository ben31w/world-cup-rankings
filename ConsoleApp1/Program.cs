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

            // Create the teams from the first two matches.
            char[] delimiters = { '#', '@' };
            string[] match1 = matches[1].Split(delimiters);
            string[] match2 = matches[2].Split(delimiters);
            Team a = new Team(match1[0]);
            Team b = new Team(match1[3]);
            Team c = new Team(match2[0]);
            Team d = new Team(match2[3]);

            // Loop through the matches and add to each team's stats.
            for (int i = 1; i < matches.Length; i++)
            {
                // Match array: {"awayTeam", "awayTeamGoals", "homeTeamGoals", "homeTeam"}
                //               0           1                2                3
                string[] matchArray = matches[i].Split(delimiters);
                
                Team home;
                Team away;
                if ( matchArray[0].Equals(a.Name) )
                {
                    away = a;
                }
                else if ( matchArray[0].Equals(b.Name) )
                {
                    away = b;
                }
                else if ( matchArray[0].Equals(c.Name) )
                {
                    away = c;
                }
                else
                {
                    away = d;
                }
                if ( matchArray[3].Equals(a.Name) )
                {
                    home = a;
                }
                else if ( matchArray[3].Equals(b.Name) )
                {
                    home = b;
                }
                else if ( matchArray[3].Equals(c.Name) )
                {
                    home = c;
                }
                else
                {
                    home = d;
                }

                UpdateStats(matchArray, away, home);
            }

            Team[] teams = { a, b, c, d };
            Array.Sort(teams);

            foreach (Team team in teams)
            {
                Console.WriteLine(team);
            }

            return rankings;
        }

        /**
         * Read in a match string, and update the stats of the two teams playing in the match.
         * 
         * Match array has the form:   {"awayTeam", "awayTeamGoals", "homeTeamGoals", "homeTeam"}
         *                              0           1                2                3
         */
        static void UpdateStats(string[] matchArray, Team away, Team home)
        {
            // Increment games played.
            away.GamesPlayed += 1;
            home.GamesPlayed += 1;

            // Update net goals, goals scored, and goals against.
            int awayGoals = Int32.Parse(matchArray[1]);
            int homeGoals = Int32.Parse(matchArray[2]);
            away.NetGoals += awayGoals - homeGoals;
            away.GoalsScored += awayGoals;
            away.GoalsAgainst += homeGoals;
            home.NetGoals += homeGoals - awayGoals;
            home.GoalsScored += homeGoals;
            home.GoalsAgainst += awayGoals;

            // TIE: TIE: +1 pts, +1 tie for both teams
            if (awayGoals == homeGoals)
            {
                away.Points += 1;
                away.Ties += 1;
                home.Points += 1;
                home.Ties += 1;
            }
            // AWAY TEAM WINS: +3 pts, +1 win for away team; +1 loss for home team
            else if (awayGoals > homeGoals)
            {
                away.Points += 3;
                away.Wins += 1;
                home.Losses += 1;
            }
            // HOME TEAM WINS: +3 pts, +1 win for home team; +1 loss for away team
            else
            {
                away.Losses += 1;
                home.Points += 3;
                home.Wins += 1;
            }
        }

        static void Main(string[] args)
        {
        }
    }


    class Team: IComparable<Team>
    {
        string _name;
        int _points;
        int _gamesPlayed;
        int _wins;
        int _ties;
        int _losses;
        int _netGoals;
        int _goalsScored;
        int _goalsAgainst;

        public string Name
        {
            get => _name; 
            set => _name = value;
        }
        public int Points
        {
            get => _points; 
            set => _points = value;
        }
        public int GamesPlayed
        {
            get => _gamesPlayed;
            set => _gamesPlayed = value;
        }
        public int Wins
        {
            get => _wins;
            set => _wins = value;
        }
        public int Ties
        {
            get => _ties;
            set => _ties = value;
        }
        public int Losses
        {
            get => _losses;
            set => _losses = value;
        }
        public int NetGoals
        {
            get => _netGoals;
            set => _netGoals = value;
        }
        public int GoalsScored
        {
            get => _goalsScored;
            set => _goalsScored = value;
        }
        public int GoalsAgainst
        {
            get => _goalsAgainst;
            set => _goalsAgainst = value;
        }

        public Team(String name)
        {
            _name = name;
            _points = 0;
            _gamesPlayed = 0;
            _wins = 0;
            _ties = 0;
            _losses = 0;
            _netGoals = 0;
            _goalsScored = 0;
            _goalsAgainst = 0;
        }

        public override string ToString()
        {
            // e.g., Spain 6p, 3g (2-0-1), 2gd (4-2)"
            return $"{_name} {_points}p, {_gamesPlayed}g ({_wins}-{_ties}-{_losses}), {_netGoals}gd ({_goalsScored}-{_goalsAgainst})";
        }

        /**
         * Comparison criteria for two teams is incremental (i.e., next rule applies when there are ties):
         * 1. Most points earned
         * 2. Most wins
         * 3. Most goal difference (i.e., goals scored - goals against)
         * 4. Most goals scored
         * 5. Less matches played
         * 6. Alphabetical order (i.e., ascending)
         * 
         * return -1 if this team ranks before the other team
         *         1 if this team ranks after the other team
         */
        public int CompareTo(Team other)
        {
            if (other == null)
            {
                return 1;
            }

            Team otherTeam = other as Team;
            if (otherTeam == null)
            {
                throw new ArgumentException("Comparison object is not a Team");
            }

            // 1. Which team has more points?
            if (this._points > otherTeam._points)
            {
                return -1;
            }
            else if (this._points < otherTeam._points)
            {
                return 1;
            }
            // 2. Which team has more wins?
            if (this._wins > otherTeam._wins)
            {
                return -1;
            }
            else if (this._wins < otherTeam._wins)
            {
                return 1;
            }
            // 3. Which team has a better goal differential?
            if (this._netGoals > other._netGoals)
            {
                return -1;
            }
            else if (this._netGoals < other._netGoals)
            {
                return 1;
            }
            // 4. Which team has scored more goals?
            if (this._goalsScored > other._goalsAgainst)
            {
                return -1;
            }
            else if (this._goalsScored < other._goalsAgainst)
            {
                return 1;
            }
            // 5. Which team has played less matches?
            if (this._gamesPlayed < other._gamesPlayed)
            {
                return -1;
            }
            else if (this._gamesPlayed > other._gamesPlayed)
            {
                return 1;
            }
            // 6. Which team comes first in alphabetical order?
            return this._name.CompareTo(other._name);
        }
        
    }

}
