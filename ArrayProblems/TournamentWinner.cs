namespace ArrayProblems;
internal class TournamentWinner
{
    public class Program
    {
        public string TournamentWinner(
          List<List<string>> competitions, List<int> results
        )
        {
            var scoresByTeam = new Dictionary<string, int>();
            var maxScore = 0;
            var winner = "";
            for (var i = 0; i <= competitions.Count; i++)
            {
                var competition = competitions[i];
                var competitionWinner = results[i] == 1 ? competition[0] : competition[1];
                if (!scoresByTeam.TryGetValue(competitionWinner, out var score))
                {
                    score = 0;
                }
                scoresByTeam[competitionWinner] = score + 3;
                if (scoresByTeam[competitionWinner] > maxScore)
                {
                    maxScore = scoresByTeam[competitionWinner];
                    winner = competitionWinner;
                }
            }

            return winner;
        }
    }
}
