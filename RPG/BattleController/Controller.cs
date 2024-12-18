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
            this.view.Update += Update;
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
            this.view.UpdateHP(this.model.Team1, this.model.Team2, this.model.DefenderTeam);
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
                Winner();
            }
            else
            {
                Update();
            }
        }
        private void HandleSpecial()
        {
            //model.PerformAttack();
            Console.WriteLine("Attack performed!");
            this.view.player1 = 0; this.view.player2 = 0; //reset selected
            this.model.EndTurn();
            if (this.model.EndTurn())
            {
                Winner();
            }
            else
            {
                this.view.roundCount++;
                Update();
                
            }
        }
        private void HandleUltimate()
        {
            //model.PerformAttack();
            Console.WriteLine("Attack performed!");
            this.view.player1 = 0; this.view.player2 = 0; //reset selected
            this.model.EndTurn();
            if (this.model.EndTurn())
            {
                Winner();
            }
            else
            {
                Update();
                this.view.roundCount++;
            }
        }
        private void HandleBlock()
        {
            //model.();
            Console.WriteLine("Attack performed!");
            this.view.player1 = 0; this.view.player2 = 0; //reset selected
            this.model.EndTurn();
            if (this.model.EndTurn())
            {
                Winner();
            }
            else
            {
                Update();
                this.view.roundCount++;
            }
        }
        #endregion
        #region End Game
        private void Winner()
        {
            this.view.EndGame(this.model.Victor);
            //sql
        }
        #endregion
    }
}
