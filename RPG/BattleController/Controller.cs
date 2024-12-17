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

        public Controller(List<Class> player1Team, List<Class> player2Team, string user1, string user2)
        {
            this.model = new Model(player1Team, player2Team, user1, user2);
            this.view = new BattleView.View();

            //view events
            this.view.AttackButton += HandleAttack;
            this.view.SpecialButton += HandleSpecial;
            this.view.UltimateButton += HandleUltimate;
            this.view.BlockButton += HandleBlock;
            this.view.Update += Start;
        }

        public void StartBattle()
        {
            this.view.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Start();
            this.view.ShowDialog();
        }
        #region updateUI
        /// <summary>
        /// Start UI load
        /// </summary>
        private void Start()
        {
            this.view.UpdatePic(this.model.Team1, this.model.Team2);
            this.view.UpdateText(this.model.username1, this.model.username2, this.model.Team1, this.model.Team2);
            this.view.UpdateHP(this.model.Team1, this.model.Team2);
        }
        #endregion
        #region Model Actions
        private void HandleAttack()
        {
            //int damage=model.PerformAttack();
            this.view.battleLog.Add("Attack performed!");
        }
        private void HandleSpecial()
        {
            //model.PerformAttack();
            Console.WriteLine("Attack performed!");
        }
        private void HandleUltimate()
        {
            //model.PerformAttack();
            Console.WriteLine("Attack performed!");
        }
        private void HandleBlock()
        {
            //model.PerformAttack();
            Console.WriteLine("Attack performed!");
        }
        #endregion
    }
}
