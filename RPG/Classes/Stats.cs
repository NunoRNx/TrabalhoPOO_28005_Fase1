//using System.Drawing.Common;
namespace RPG
{
    /// <summary>
    /// Superclass with all comun properties to all RPG characters
    /// </summary>
    public abstract class Class
    {
        #region Properties
        private string Name {  get; set; }
        private string Type {  get; set; }
        private int HP { get; set; }
        private int OriginalDefense { get; set; }
        private int Defense { get; set; }
        private int Streght { get; set; }
        private int Dexterity { get; set; }
        private int Stamina { get; set; }
        private int Magic { get; set; }
        private bool Alive { get; set; }
        private int SpecialCost { get; set; }
        //private Image img { get; set; }
        #endregion

        #region Constructor
        public Class(string name, string type, int hp, int defense, int streght, int dexterity, int stamina, int magic, int specialCost)
        {
            this.Name = name;
            this.Type = type;
            this.HP = hp;
            this.Defense = defense;
            this.OriginalDefense = this.Defense;
            this.Streght = streght;
            this.Dexterity = dexterity;
            this.Stamina = stamina;
            this.Magic = magic;
            this.Alive = true;
            this.SpecialCost = specialCost;
        }
        #endregion

        #region Injector
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
            set
            {
                if (value <= 0)
                {
                    this.Alive = false;
                }
                this.HP = value;
            }
        }
        public int originalDefense
        {
            get { return this.OriginalDefense; }
        }
        public int defense
        {
            get { return this.Defense; }
            set
            {
                if (value == this.OriginalDefense)
                {
                    this.Defense = value;
                }
            }
        }
        public int streght
        {
            get { return this.Streght; }
            set { this.Streght = value; }
        }
        public int dexterity
        {
            get { return this.Dexterity; }
            set { this.Dexterity = value; }
        }
        public int stamina
        {
            get { return this.Stamina; }
            set { this.Stamina = value; }
        }
        public int magic
        {
            get { return this.Magic; }
            set { this.Magic = value; }
        }
        public bool alive
        {
            get { return this.Alive; }
            set { this.alive = value; }
        }
        public int cost
        {
            get { return this.SpecialCost; }
            set { this.SpecialCost = value; }
        }
        #endregion

        #region abstraction
        public abstract int attack();
        public abstract int special();
        #endregion
    }
}
