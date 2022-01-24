# world-cup-rankings
Assignment 1 for CPSC 360

This program calculates the rankings of teams in the FIFA World Cup group stage. 
It reads in an array of strings containing World Cup scores, and determines how the teams should be ranked.

The strings have this format:<br>
"AwayTeam#AwayGoalsScored@HomeGoalsScored#HomeTeam"<br>
(Examples: "Honduras#0@1#Chile", "Spain#0@1#Switzerland")

The final rankings have this format:<br>
 "World Cup 2010: Group H",<br>
 "1) Spain 6p, 3g (2-0-1), 2gd (4-2)",<br>
 "2) Chile 6p, 3g (2-0-1), 1gd (3-2)",<br>
 "3) Switzerland 4p, 3g (1-1-1), 0gd (1-1)",<br>
 "4) Honduras 1p, 3g (0-1-2), -3gd (0-3)"<br>
 
 p = points (3 points of a win, 1 point for a tie)<br>
 g = games played (followed by W-T-L)<br>
 gd = goal differential (goals scored - goals against)
