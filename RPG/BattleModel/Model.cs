using RPG;

namespace BattleModel
{
    public class Model
    {
        private string user1 { get; }
        private List<Class> team1 { get; }
        private string user2 { get; set; }
        private List<Class> team2 { get; set; }
        private int currentTurn {  get; set; }

        public Model(List<Class> team1, List<Class> team2, string player1, string player2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.user1 = player1;
            this.user2 = player2;
            this.currentTurn = 1;
        }
        public string username1 => user1;
        public string username2 => user2;
        public List<Class> Team1 => team1;
        public List<Class> Team2 => team2;

        #region Actions
        /*
        /// <summary>
        /// Check whose turn it is (Player 1 or Player 2)
        /// </summary>
        public int GetCurrentTurn()
        {
            return currentTurn;
        }

        /// <summary>
        /// Switch turns between players
        /// </summary>
        public void EndTurn()
        {
            currentTurn = (currentTurn == 1) ? 2 : 1; // Alternate between 1 and 2
        }

        /// <summary>
        /// Perform an attack for the current player.
        /// </summary>
        public int PerformAttack(int attackerIndex, int defenderIndex)
        {
            List<Class> currentTeam = (currentTurn == 1) ? team1 : team2;
            List<Class> enemyTeam = (currentTurn == 1) ? team2 : team1;

            Class attacker = currentTeam[attackerIndex];
            Class defender = enemyTeam[defenderIndex];

            int damage = attacker.Attack(); // Call the Attack method from Class
            defender.TakeDamage(damage);

            return damage;
        }

        /// <summary>
        /// Check if a team has been defeated
        /// </summary>
        public bool IsGameOver()
        {
            return team1.All(c => c.IsDead()) || team2.All(c => c.IsDead());
        }

        public string GetWinner()
        {
            if (team1.All(c => c.IsDead())) return user2;
            if (team2.All(c => c.IsDead())) return user1;
            return "No Winner Yet";
        }*/
        #endregion
    }
}
