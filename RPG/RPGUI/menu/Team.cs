using System;
using System.Windows.Forms;
using RPG;

namespace RPGUI
{
    public partial class Team : Form
    {
        private const int MaxTeamSize = 3; // Constant for maximum team size
        private BattleTeams team { get; set; }
        public bool status=false;
        public BattleTeams SelectedTeam
        {
            get { return this.team; }
        }

        public Team()
        {
            InitializeComponent();

            // Subscribe to the CheckedChanged event for each checkbox
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox_CheckedChanged;
            checkBox5.CheckedChanged += CheckBox_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox_CheckedChanged;

            // Wire up the button click event
            button1.Click += ButtonSelect_Click;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Get the currently checked checkbox count
            int checkedCount = 0;
            CheckBox[] checkboxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };

            foreach (var checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    checkedCount++;
                }
            }

            // If more than MaxTeamSize checkboxes are checked, uncheck the last one
            if (checkedCount > MaxTeamSize)
            {
                // Uncheck the checkbox that triggered the event if the limit is exceeded
                CheckBox currentCheckbox = sender as CheckBox;
                if (currentCheckbox != null)
                {
                    currentCheckbox.Checked = false;
                    MessageBox.Show($"You can only select up to {MaxTeamSize} characters.");
                }
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            buttonSelect(); // Get the team selection

            // Perform any further actions with the selected team
            if (this.team.team.Count == MaxTeamSize)
            {
                MessageBox.Show("Team selected successfully!");
                this.DialogResult = DialogResult.OK;
                //maybe insert update database here
                status = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must select 3 characters to start.");
            }
        }

        private void buttonSelect()
        {
            int i = 0;
            team=new BattleTeams();
            // Check each checkbox and create objects accordingly
            if (checkBox1.Checked && i < MaxTeamSize)
            {
                Warrior charc = new Warrior(250, 50, 70, 50); // Health, Defense, Strength, Rage
                this.team.add(charc);
            }

            if (checkBox2.Checked && i < MaxTeamSize)
            {
                Paladin charc = new Paladin(220, 60, 50, 30); // Health, Defense, Strength, Holy
                this.team.add(charc);
            }

            if (checkBox3.Checked && i < MaxTeamSize)
            {
                Swordsman charc = new Swordsman(210, 40, 80, 40); // Health, Defense, Strength, Focus
                this.team.add(charc);
            }

            if (checkBox4.Checked && i < MaxTeamSize)
            {
                Assassin charc = new Assassin(180, 30, 60, 90, 40); // Health, Defense, Strength, Dexterity, Stealth
                this.team.add(charc);
            }

            if (checkBox5.Checked && i < MaxTeamSize)
            {
                Archer charc = new Archer(190, 35, 50, 100, 30); // Health, Defense, Strength, Dexterity, Arrows
                this.team.add(charc);
            }

            if (checkBox6.Checked && i < MaxTeamSize)
            {
                Mage charc = new Mage(160, 20, 40, 90, 50); // Health, Defense, Strength, Magic, Mana
                this.team.add(charc);
            }
        }
    }
}
