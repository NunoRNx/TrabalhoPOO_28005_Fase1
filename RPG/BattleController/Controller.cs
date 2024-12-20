using BattleModel;
using BattleView;
using RPG;
using System.Windows.Forms;

namespace BattleController
{
    public class Controller
    {
        private Model model;
        private BattleView.View view;
        private Class selected {  get; set; }
        private Class enemy { get; set; }

        public Controller(List<Class> player1Team, List<Class> player2Team, string user1, string user2)
        {
            this.model = new Model(player1Team, player2Team, user1, user2);
            this.view = new BattleView.View();

            //view events
            this.view.AttackButton += HandleAttack;
            this.view.SpecialButton += HandleSpecial;
            this.view.UltimateButton += HandleUltimate;
            this.view.BlockButton += HandleBlock;
            this.view.UpdateUI += Update;
            this.view.CloseGame += Close;
        }

        #region Start & Update View
        /// <summary>
        /// Start View & Load Names and Pictures
        /// </summary>
        public void StartBattle()
        {
            this.view.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.view.UpdatePic(this.model.Team1, this.model.Team2);
            this.view.UpdateText(this.model.username1, this.model.username2, this.model.Team1, this.model.Team2);
            this.view.roundCount = 0;
            this.model.DefenderTeam = this.model.username1;
            Update();
            this.view.ShowDialog();
        }
        
        /// <summary>
        /// Update UI
        /// </summary>
        private void Update()
        {
            this.view.UpdateValues(this.model.Team1, this.model.Team2, this.model.DefenderTeam);
            this.view.team1 = this.model.Team1;
            this.view.team2 = this.model.Team2;
        }
        #endregion
        #region Model Actions
        private void HandleAttack()
        {
            int damage=model.PerformAttack(this.view.player1, this.view.player2);
            this.view.battleLog.Add(this.model.dice);
            this.view.battleLog.Add(this.model.log);
            //reset selected
            this.view.player1=0;
            this.view.player2=0;
            if (this.model.EndTurn())
            {
                Update();
                Winner();
            }
            else
            {
                Update();
            }
        }
        private void HandleSpecial()
        {
            if (this.model.CanUse(this.view.player1, this.view.player2, 20))
            {
                int damage = model.PerformSpecial(this.view.player1, this.view.player2);
                this.view.battleLog.Add(this.model.dice);
                this.view.battleLog.Add(this.model.log);
                //reset selected
                this.view.player1 = 0;
                this.view.player2 = 0;
                if (this.model.EndTurn())
                {
                    Winner();
                }
                else
                {
                    Update();
                }
            }
            else
            {
                throw new Exception("Not enough power to use this ability!");
            }
        }
        private void HandleUltimate()
        {
            if (this.model.CanUse(this.view.player1, this.view.player2, 50))
            {
                int damage = model.PerformUltimate(this.view.player1, this.view.player2);
                this.view.battleLog.Add(this.model.dice);
                this.view.battleLog.Add(this.model.log);
                //reset selected
                this.view.player1 = 0;
                this.view.player2 = 0;
                if (this.model.EndTurn())
                {
                    Winner();
                }
                else
                {
                    Update();
                }
            }
            else
            {
                throw new Exception("To use the Ultimate ability you need a full gauge!");
            }
        }
        private void HandleBlock()
        {
            this.model.PerformBlock(this.view.player1, this.view.player2);
            this.view.battleLog.Add(this.model.dice);
            this.view.battleLog.Add(this.model.log);
            //reset selected
            this.view.player1 = 0;
            this.view.player2 = 0;
            if (this.model.EndTurn())
            {
                Winner();
            }
            else
            {
                Update();
            }
        }
        #endregion
        #region End Game
        private void Close()
        {
            this.view.Close();
            this.view = null;
            this.model = null;
            GC.Collect();
        }
        private void Winner()
        {
            //sql
            IncreaseMatches(this.model.username1, this.model.username2);
            IncreaseWin(this.model.Victor);
            //end game pop up
            this.view.EndGame(this.model.Victor);
            Close();
        }
        private void IncreaseWin(string winner)
        {
            SQL db = SQL.Instance;
            //Increase Wins counter for the winner
            db.IncreaseWin(winner);
        }
        private void IncreaseMatches(string username1, string username2)
        {
            SQL db = SQL.Instance;
            //Increase Match counter for both players
            db.IncreaseMatches(username1);
            db.IncreaseMatches(username2);
        }
        #endregion
    }
}
