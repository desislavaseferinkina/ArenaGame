using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; set; }
        public int AttackBonus { get; set; }
        public string SpecialAbility { get; set; }
        public int Damage { get; set; }

        public Weapon(string name, int attackBonus, string specialAbility, int damage)
        {
            Name = name;
            AttackBonus = attackBonus;
            SpecialAbility = specialAbility;
            Damage = damage;
        }

        public virtual void UseSpecialAbility(Hero target)
        {
            // Специалната способност се дефинира в наследниците
        }
    }
}
