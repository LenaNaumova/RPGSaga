namespace CourseApp
{
    public class FireArrow : IAbbility
    {
        public FireArrow(int strength)
        {
            Damage = 2 * strength;
        }

        public string Name { get; } = "Fire Arrow";

        public int Damage { get; }

        public int NumberOfUses { get; }

        public int DurationOfAction { get; }
    }
}