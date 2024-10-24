using NUnit.Framework;
using RPG;
namespace Utils
{
    public class ActionTest
    {
        private Warrior personagem;
        private Swordsman enemy;
        [SetUp]
        public void Setup()
        {
            personagem = new Warrior(10,10,10,10,10,10,10);
            enemy = new Swordsman(10,10,10,10,10,10,10);
        }

        [Test]
        public void Attack()
        {
            //act
            var value=personagem.attack();

            //assert
            Assert.AreEqual(0, value);
        }
        [Test]
        public void InflictDamage()
        {
            Actions.inflict(10, enemy);
            Console.WriteLine("enemy hp: "+enemy.hp);
            Assert.AreEqual(false, enemy.alive);
        }
    }
}