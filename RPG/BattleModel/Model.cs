using RPG;

namespace BattleModel
{
    public class Model
    {
        private string user1 { get; }
        private List<Class> team1 { get; }
        private string user2 { get; }
        private List<Class> team2 { get; }
        private int currentTurn {  get; set; }
        private Class attacker { get; set; }
        private Class defender { get; set; }
        private string attackerTeam { get; set; }
        private string defenderTeam { get; set; }
        private string victor { get; set; }
        public string dice;
        public string log;

        public Model(List<Class> team1, List<Class> team2, string player1, string player2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.user1 = player1;
            this.user2 = player2;
            this.currentTurn = 1;
            this.attacker = null;
            this.attackerTeam = null;
            this.defenderTeam = null;
            this.defender = null;
            this.victor = null;
        }
        public string username1 => user1;
        public string username2 => user2;
        public List<Class> Team1 => team1;
        public List<Class> Team2 => team2;
        public string AttackerTeam
        {
            get { return this.attackerTeam; }
            set { this.attackerTeam = value; }
        }
        public string DefenderTeam {
            get{ return this.defenderTeam; }
            set{ this.defenderTeam = value; }
        }
        public string Victor => this.victor;
        

        /// <summary>
        /// Check whose turn it is (Player 1 or Player 2)
        /// </summary>
        public int GetCurrentTurn
        {
            get { return currentTurn; }
            set { currentTurn = value; }
        }
        #region New Round
        /// <summary>
        /// Switch turns between players
        /// </summary>
        public bool EndTurn()
        {
            currentTurn = (currentTurn == 1) ? 2 : 1; // Alternate between 1 and 2
            ResetSelected();
            ResetDefense();
            return IsGameOver();
        }
        private void GetSelected(int team1Index, int team2Index)
        {
            List<Class> currentTeam = (currentTurn == 1) ? team1 : team2; //if true team 1 else team 2
            List<Class> enemyTeam = (currentTurn == 1) ? team2 : team1;
            if (currentTurn == 1)
            {
                this.attacker = currentTeam[team1Index];
                this.attackerTeam = user1;
                //block action can be perfomed with only the attacker selected
                if (team2Index != -1)
                {
                    this.defender = enemyTeam[team2Index];
                    this.defenderTeam = user2;
                }
            }
            else
            {
                this.attacker = currentTeam[team2Index];
                this.attackerTeam = user2;
                //block action can be perfomed with only the attacker selected
                if (team1Index != -1)
                {
                    this.defender = enemyTeam[team1Index];
                    this.defenderTeam = user1;
                }
            }
            
        }
        /// <summary>
        /// Block Actions provides a defense buff but it only precists for 1 round
        /// When it becomes the players turn to play again after using block the buff is voided for all characters of his team
        /// </summary>
        private void ResetDefense()
        {
            List<Class> Team = (currentTurn == 1) ? team1 : team2;
            foreach (Class c in Team)
            {
                c.defense = c.originalDefense;
            }
        }
        private void ResetSelected()
        {
            this.attacker = null;
            this.defender = null;
        }
        #endregion
        #region Check Action
        public bool CanUse(int team1Index, int team2Index, int cost)
        {
            GetSelected(team1Index, team2Index);
            if (this.attacker.GetGauge() >= cost)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Actions

        /// <summary>
        /// Perform an attack and inflict the appropriate damage
        /// </summary>
        public int PerformAttack(int attackerIndex, int defenderIndex)
        {
            GetSelected(attackerIndex, defenderIndex);

            int damage = this.attacker.Attack(); // Call the Attack method from Class
            double defense = this.defender.defense / 100.0; //take into account the character defense stat
            damage = (int)(inflict(damage, out int roll) * defense); //calculate damage
            this.defender.hp -= damage; //inflict damage

            //log making
            this.dice = this.attackerTeam + " rolled: " + roll;
            this.log = this.attackerTeam + "'s " + this.attacker.name + " performed Basic Attack on " + this.defenderTeam + "'s " + this.defender.name + " and did " + damage + " damage!";

            return damage;
        }
        public int PerformSpecial(int attackerIndex, int defenderIndex)
        {
            GetSelected(attackerIndex, defenderIndex);

            int damage = this.attacker.Special(); // Call the Attack method from Class
            double defense = this.defender.defense / 100.0; //take into account the character defense stat
            damage = (int)(inflict(damage, out int roll) * defense); //calculate damage
            this.defender.hp -= damage; //inflict damage

            //log making
            this.dice = this.attackerTeam + " rolled: " + roll;
            this.log = this.attackerTeam + "'s " + this.attacker.name + " performed his Special Attack on " + this.defenderTeam + "'s " + this.defender.name + " and did " + damage + " damage!";

            return damage;
        }
        public int PerformUltimate(int attackerIndex, int defenderIndex)
        {
            GetSelected(attackerIndex, defenderIndex);

            int damage = this.attacker.Ultimate(); // Call the Attack method from Class
            double defense = this.defender.defense / 100.0; //take into account the character defense stat
            damage = (int)(inflict(damage, out int roll) * defense); //calculate damage
            this.defender.hp -= damage; //inflict damage

            //log making
            this.dice = this.attackerTeam + " rolled: " + roll;
            this.log = this.attackerTeam + "'s " + this.attacker.name + " performed his Ultimate Attack on " + this.defenderTeam + "'s " + this.defender.name + " and did " + damage + " damage!";

            return damage;
        }
        public void PerformBlock(int attackerIndex, int defenderIndex)
        {
            GetSelected(attackerIndex, defenderIndex);

            this.attacker.Block(); // Call the Attack method from Class

            //log making
            this.dice = this.attackerTeam + " rolled: no roll for blocks";
            this.log = this.attackerTeam + "'s " + this.attacker.name + " performed Block and increased his defense from " + this.attacker.originalDefense + " to " + this.attacker.defense + "!";
        }
        #endregion
        #region base methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int diceRoll(int min, int max)
        {
            Random rand = new Random();
            int roll = rand.Next(min, max);
            return roll;
        }
        #region old calc
        public static int crit(int damage, int roll)
        {
            if (roll > 15)
            {
                return damage * 2;
            }
            return damage + damage/2;
        }
        public static int resistence(int damage, int roll)
        {
            if (roll < 5)
            {
                return damage / 2;
            }
            return damage - damage/4;
        }
        #endregion
        public static int CritResistence(int damage, int roll)
        {
            double mult = roll / 10.0;
            return (int)(damage * mult);
        }

        public static int inflict(int damage, out int roll)
        {
            roll = diceRoll(1, 21);
            //old system
            /*
            if (roll > 10)
            {
                damage = crit(damage, roll);
            }
            else if(roll < 10)
            {
                damage = resistence(damage, roll);
            }*/
            return CritResistence(damage, roll);
        }
        #endregion
        #region End Game
        /// <summary>
        /// Check if a team has been defeated
        /// </summary>
        public bool IsGameOver()
        {
            if (team1.All(c=> !c.alive) || team2.All(c => !c.alive))
            {
                GetWinner();
                return true;
            }
            return false;
        }

        public void GetWinner()
        {
            if (team1.All(c => !c.alive)) this.victor = user2;
            else this.victor = user1;
        }
        #endregion
    }
}
