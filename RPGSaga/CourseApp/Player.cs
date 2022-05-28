namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public abstract class Player
    {
        private List<IAbbility> abbilities = new List<IAbbility>();

        private Random random = new Random();

        public Player(string name, int hp, int strength, string role) // Конструктор игрока
        {
            this.Name = name;
            this.HP = hp;
            this.Strength = strength;
            abbilities.Add(new Attack(strength));
            Role = role;
        }

        public string Role { get; set; }

        public string Name { get; set; }

        public int HP { get; set; }

        public int Strength { get; set; }

        public List<IAbbility> Abbilities
        {
            get
            {
                return abbilities;
            }

            set
            {
                abbilities = value;
            }
        }

        public IAbbility Attack()
        {
            return Abbilities[random.Next(abbilities.Count)];
        }

        public void GetAttack(IAbbility attack)
        {
            HP = HP - attack.Damage;
        }
    }
}
