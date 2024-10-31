﻿using System;
using System.Windows.Forms;
using RPG;

namespace RPGUI
{
    public partial class Team : Form
    {
        private const int MaxTeamSize = 3; // Constant for maximum team size
        private BattleTeams team { get; set; }

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
                Warrior charc = new Warrior(10, 10, 10, 10, 10, 10, 10);
                this.team.add(charc);
            }

            if (checkBox2.Checked && i < MaxTeamSize)
            {
                Paladin charc = new Paladin(10, 10, 10, 10, 10, 10, 10);
                this.team.add(charc);
            }

            if (checkBox3.Checked && i < MaxTeamSize)
            {
                Swordsman charc = new Swordsman(10, 10, 10, 10, 10, 10, 10);
                this.team.add(charc);
            }

            if (checkBox4.Checked && i < MaxTeamSize)
            {
                Assassin charc = new Assassin(10, 10, 10, 10, 10, 10, 10);
                this.team.add(charc);
            }

            if (checkBox5.Checked && i < MaxTeamSize)
            {
                Archer charc = new Archer(10, 10, 10, 10, 10, 10, 10);
                this.team.add(charc);
            }

            if (checkBox6.Checked && i < MaxTeamSize)
            {
                Mage charc = new Mage(10, 10, 10, 10, 10, 10, 10);
                this.team.add(charc);
            }
        }
    }
}
