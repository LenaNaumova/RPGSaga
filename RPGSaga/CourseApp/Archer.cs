namespace CourseApp
{
    public class Archer : Player
    {
        public Archer(string name, int hp, int strenght)
            : base(name, hp, strenght, "Archer") // Наследование
        {
            Abbilities.Add(new FireArrow(Strength));
        }
    }
}
