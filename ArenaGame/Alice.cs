using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Alice : Hero
    {
        const int BlockDamageChance = 12;
        private const int ExtraDamageChance = 7;
        private int attackCount;
        private Weapon equippedWeapon;
        public int HealEachNthRound { get; private set; }

        public Alice() : this("Alice")
        {

        }

        public Alice(string name) : base(name, new Weapon("PlayingCards", 10, "Hit", 25))
        {
        }

        public override void TakeDamage(int incomingDamage)
        {  
            if (ThrowDice(BlockDamageChance)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ExtraDamageChance))
            {
                attack = attack * 130 / 100;
                if (equippedWeapon != null)
                {
                    attack += equippedWeapon.Damage;
                }
            }
            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 40 / 100);
            }

            return attack;
        }
        public void UseSpecialAbility(Hero target)
        {
            Console.WriteLine($"{Name} uses Playing Cards on {target.Name} for double damage!");
            target.TakeDamage(20);
        }
    }
}
