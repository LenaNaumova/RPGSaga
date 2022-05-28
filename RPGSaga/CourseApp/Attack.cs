namespace CourseApp
{
    public class Attack : IAbbility
    {
        public Attack(int strength) // Конструктор
        {
            Damage = strength;
        }

        public string Name { get; } = "Base Attack";

        public int Damage { get; }

        public int NumberOfUses { get; } // Количество использований

        public int DurationOfAction { get; } // Продолжительность действия
    }
}
