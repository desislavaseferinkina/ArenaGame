using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class FireBall : Weapon
    {
        public FireBall() : base("Fire Ball", 10, "Burn", 30)
        {

        }

        public override void UseSpecialAbility(Hero target)
        {
            Console.WriteLine($"{target.Name} is burned for 11 extra damage!");
            target.TakeDamage(11);
        }
    }
}
