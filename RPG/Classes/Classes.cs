namespace RPG
{
    /// <summary>
    /// All Classes that can be chosen
    /// </summary>
    #region Shields
    public class Warrior : Class
    {
        private int Rage { get; set; }

        public Warrior(int hp, int defense, int strength, int rage)
            : base(1,"The Warrior", hp, defense, strength, 100, 50)
        {
            this.Rage = rage;
        }
        #region Actions
        public override int Attack()
        {
            this.Rage = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.strength * 1.2); // Basic attack with a bit more power
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.5); // 50% stronger than normal
            this.Rage -= 20; // Consumes some rage
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 3.5);
            this.Rage = 0; // Consumes all rage
            return damage;
        }

        public override void Block()
        {
            this.Rage = RechargeGauge(15); // Recharge rage when blocking
            this.defense += 30; // Buffs defense temporarily for blocking stance
        }

        public override int GetGauge()
        {
            return this.Rage; // Return the current rage gauge value
        }
        #endregion
    }

    public class Paladin : Class
    {
        private int Holy { get; set; }

        public Paladin(int hp, int defense, int strength, int holy)
            : base(2, "Holy Knight", hp, defense, strength, 100, 50)
        {
            this.Holy = holy;
        }
        #region Actions
        public override int Attack()
        {
            this.Holy = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.strength * 1.1); // Less attack power but more balanced
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.3 + Holy * 0.3); // Holy power influences special attack
            this.Holy -= 20; // Consumes some holy power
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 3 + Holy * 0.5);
            this.Holy = 0; // Consumes all holy power
            return damage;
        }

        public override void Block()
        {
            this.Holy = RechargeGauge(15);
            this.defense += 30;
        }

        public override int GetGauge()
        {
            return this.Holy; // Return the current holy power value
        }
        #endregion
    }
    #endregion

    #region Vanguard
    public class Swordsman : Class
    {
        private int Focus { get; set; }

        public Swordsman(int hp, int defense, int strength, int focus)
            : base(3,"Sword Master", hp, defense, strength, 100, 50)
        {
            this.Focus = focus;
        }
        #region Actions
        public override int Attack()
        {
            this.Focus = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.strength * 1.3); // Strong attack
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.7);
            this.Focus -= 20; // Consumes focus points
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 2.5);
            this.Focus = 0; // Consumes all focus points
            return damage;
        }

        public override void Block()
        {
            this.Focus = RechargeGauge(15);
            this.defense += 15;
        }

        public override int GetGauge()
        {
            return this.Focus; // Return the current focus value
        }
        #endregion
    }

    public class Assassin : Class
    {
        private int Stealth { get; set; }
        private int Dexterity { get; set; } // Only initialized here for Assassin

        public Assassin(int hp, int defense, int strength, int dexterity, int stealth)
            : base(4, "Assassin", hp, defense, strength, 100, 50)
        {
            this.Stealth = stealth;
            this.Dexterity = dexterity; // Only initialize dexterity here
        }
        #region Actions
        public override int Attack()
        {
            this.Stealth = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.strength * 1.4); // Stronger attack
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.2 + this.Dexterity * 0.5); // Dexterity influences damage
            this.Stealth -= 20; // Consumes stealth power
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 2.0 + this.Dexterity * 0.8); // Dexterity used in ultimate
            this.Stealth = 0; // Consumes all stealth power
            return damage;
        }

        public override void Block()
        {
            this.Stealth = RechargeGauge(15);
            this.defense += 10;
        }

        public override int GetGauge()
        {
            return this.Stealth; // Return the current stealth power value
        }
        #endregion
    }
    #endregion

    #region Offensive
    public class Archer : Class
    {
        private int Arrows { get; set; }
        private int Dexterity { get; set; } // Only initialized here for Archer

        public Archer(int hp, int defense, int strength, int dexterity, int arrows)
            : base(5, "The Arrow", hp, defense, strength, 100, 50)
        {
            this.Arrows = arrows;
            this.Dexterity = dexterity; // Only initialize dexterity here
        }
        #region Actions
        public override int Attack()
        {
            this.Arrows = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.Dexterity * 1.5); // Dexterity-based attack
        }

        public override int Special()
        {
            int damage = (int)(this.Dexterity * 2.0);
            this.Arrows -= 20; // Consumes some arrows for special
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.Dexterity * 2.5);
            this.Arrows -= 5; // Drains significant arrows
            return damage;
        }

        public override void Block()
        {
            this.Arrows = RechargeGauge(15);
            this.defense += 5;
        }

        public override int GetGauge()
        {
            return this.Arrows; // Return the current arrows value
        }
        #endregion
    }

    public class Mage : Class
    {
        private int Mana { get; set; }
        private int Magic { get; set; } // Only initialized here for Mage

        public Mage(int hp, int defense, int strength, int magic, int mana)
            : base(6, "The Sage", hp, defense, strength, 100, 50)
        {
            this.Mana = mana;
            this.Magic = magic; // Only initialize magic here
        }
        #region Actions
        public override int Attack()
        {
            this.Mana = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.Magic * 1.1); // Basic attack using magic
        }

        public override int Special()
        {
            int damage = (int)(Magic * 1.7);
            this.Mana -= 20; // Consume mana for special
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(Magic * 3.0); // Ultimate consumes all mana
            this.Mana = 0;
            return damage;
        }

        public override void Block()
        {
            this.Mana = RechargeGauge(15);
            this.defense += 5;
        }

        public override int GetGauge()
        {
            return this.Mana; // Return the current mana value
        }
        #endregion
    }
    #endregion
}