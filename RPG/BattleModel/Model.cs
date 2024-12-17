using RPG;

namespace BattleModel
{
    public class Model
    {
        private string user1 {  get; set; }
        private BattleTeams team1 { get; set; }
        private string user2 { get; set; }
        private BattleTeams team2 { get; set; }
        private int currentTurn {  get; set; }

        public Model(BattleTeams team1, BattleTeams team2, string player1, string player2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.user1 = player1;
            this.user2 = player2;
        }
    }
}
