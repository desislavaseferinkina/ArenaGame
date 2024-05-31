using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Rogue : Hero
    {
        private const int TripleDamageMagicLastDigit = 5;
        private const int HealEachNthRound = 3;
        private int attackCount;
        private Weapon equippedWeapon;
        public Rogue(string name) : base(name, new Weapon("IceRain", 9, "Freeze", 20))
        {
            attackCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (attack % 25 == TripleDamageMagicLastDigit)
            {
                attack = attack * 3;
            }
            attackCount = attackCount + 1;
            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 50 / 100);
            }
            if (equippedWeapon != null)
            {
                attack += equippedWeapon.Damage;
            }
            return attack;


        }
        public void UseSpecialAbility(Hero target)
        {
            Console.WriteLine($"{Name} uses Fire Ball on {target.Name} for double damage!");
            target.TakeDamage(15);
        }
        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(30)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}

