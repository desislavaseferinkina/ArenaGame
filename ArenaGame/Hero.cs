namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        public Weapon Weapon { get; private set; }
        public int Damage { get; private set; }

        protected int StartingHealth { get; private set; }
        public bool IsDead { get { return Health <= 0; } }

        public Hero(string name, Weapon weapon)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
            Weapon = weapon;
 
        }

        public virtual int Attack()
        {
            int attack = (Strength * Random.Shared.Next(80, 121)) / 100;
            if (Weapon != null)
            {
                attack += Weapon.Damage;
            }
            return attack;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
            Console.WriteLine($"{Name} now has {Health} health left.");
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
