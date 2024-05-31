using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class PlayingCards : Weapon
    {

        public PlayingCards() : base("Playing Cards", 11, "Hit", 25)
        {
        }

        public override void UseSpecialAbility(Hero target)
        {
            Console.WriteLine($"{target.Name} is hited for 10 extra damage!");
            target.TakeDamage(10);
        }
    }
}
