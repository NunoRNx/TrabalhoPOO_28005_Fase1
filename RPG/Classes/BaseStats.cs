﻿//using System.Drawing.Common;
namespace RPG
{
    /// <summary>
    /// Superclass with common properties for all RPG characters
    /// </summary>
    public abstract class Class
    {
        #region Properties
        private string Name { get; set; }
        private string Type { get; set; }
        private int HP { get; set; }
        private int OriginalDefense { get; set; }
        private int Defense { get; set; }
        private int Strength { get; set; }
        private int Stamina { get; set; }
        private int UltimateGaugeSize { get; set; }
        #endregion

        #region Constructor
        public Class(string name, string type, int hp, int defense, int strength, int stamina, int ultimateGaugeSize)
        {
            this.Name = name;
            this.Type = type;
            this.HP = hp;
            this.Defense = defense;
            this.OriginalDefense = defense;
            this.Strength = strength;
            this.Stamina = stamina;
            this.UltimateGaugeSize = ultimateGaugeSize;
        }
        #endregion

        #region Injectors
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public string type
        {
            get { return this.Type; }
            set { this.Type = value; }
        }
        public int hp
        {
            get { return this.HP; }
            set { this.HP = value; }
        }
        public int defense
        {
            get { return this.Defense; }
            set { this.Defense = value; }
        }
        public int originalDefense
        {
            get { return this.OriginalDefense; }
        }
        public int strength
        {
            get { return this.Strength; }
            set { this.Strength = value; }
        }
        public int stamina
        {
            get { return this.Stamina; }
            set { this.Stamina = value; }
        }
        public bool alive
        {
            get { return this.HP > 0; }
        }
        #endregion

        #region Abstraction
        public abstract int Attack();
        public abstract int Special();
        public abstract int Ultimate();
        public abstract void Block();
        // Abstract method to get the current gauge
        public abstract int GetGauge();

        // Recharge the gauge (subclasses will handle specific gauge recharge)
        protected int RechargeGauge(int value)
        {
            int currentGauge = GetGauge();
            currentGauge += value;
            if (currentGauge > this.UltimateGaugeSize)
                currentGauge = this.UltimateGaugeSize;
            return currentGauge; // Update the gauge in the subclass
        }
    }
    #endregion
}