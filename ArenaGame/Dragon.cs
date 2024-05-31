using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Dragon : Hero
    {
        private const int TripleDamageMagicLastDigit = 6;
        private const int HealEachNthRound = 5;
        private int attackCount;
        private Weapon equippedWeapon;
        
        public Dragon() : this("Ron")
        {

        }
        public Dragon(string name) : base(name, new Weapon("FireBall", 11, "Burn", 30))
        {
            attackCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (attack % 30 == TripleDamageMagicLastDigit)
            {
                attack = attack * 4;
            }
            attackCount = attackCount + 1;
            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 50 / 100);
            }
            return attack;
        }
        public void UseSpecialAbility(Hero target)
        {
            Console.WriteLine($"{Name} uses Fire Ball on {target.Name} for double damage!");
            target.TakeDamage(20);
        }
        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(30)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
