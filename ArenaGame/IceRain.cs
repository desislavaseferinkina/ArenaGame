using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class IceRain : Weapon
    {
        public IceRain() : base("Ice Rain", 8, "Freeze", 20)
        {

        }

        public override void UseSpecialAbility(Hero target)
        {
            Console.WriteLine($"{target.Name} is freezed for 9 extra demage!");
            target.TakeDamage(9);
        }
    }
}
